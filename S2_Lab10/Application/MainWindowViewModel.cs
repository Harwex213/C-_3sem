using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
    
    class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(Execute));
            _canExecute = canExecute;
        }
        
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        
        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;
        public void Execute(object parameter) => _execute(parameter);
    }
    
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            Products = new ObservableCollection<ProductInfo>();
            CreatedProduct = new ProductInfo();
        }
        
        private string _pathIcon;

        public ObservableCollection<ProductInfo> Products { get; set; }
        
        private ProductInfo _selectedProduct;
        public ProductInfo SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                Set(ref _selectedProduct, value);
                CreatedProduct = value;
            }
        }
        
        private ProductInfo _createdProduct;
        public ProductInfo CreatedProduct
        {
            get => _createdProduct;
            set => Set(ref _createdProduct, value);
        }

        #region Commands

        // Fields.
        private ICommand _createModelCommand;
        private ICommand _updateModelCommand;
        private ICommand _deleteModelCommand;
        private ICommand _choosePhotoCommand;

        // Props.
        public ICommand CreateModelCommand
        {
            get
            {
                _createModelCommand ??= new RelayCommand(
                    _ => CreateModel(),
                    _ => CheckModel());
        
                return _createModelCommand;
            }
        }
        
        public ICommand UpdateModelCommand
        {
            get
            {
                _updateModelCommand ??= new RelayCommand(
                    _ => UpdateModel(),
                    _ => CheckModel() && SelectedProduct is not null);
        
                return _updateModelCommand;
            }
        }
        
        public ICommand DeleteModelCommand
        {
            get
            {
                _deleteModelCommand ??= new RelayCommand(
                    _ => DeleteModel(),
                    _ => SelectedProduct is not null);
        
                return _deleteModelCommand;
            }
        }
        
        public ICommand ChoosePhotoCommand
        {
            get
            {
                _choosePhotoCommand ??= new RelayCommand(
                    _ => ChoosePhoto());
        
                return _choosePhotoCommand;
            }
        }

        // Methods.
        private bool CheckModel()
        {
            return CreatedProduct is not null &&
                   CreatedProduct?.Name?.Length != 0 &&
                   CreatedProduct?.Price != 0 &&
                   CreatedProduct?.Weight != 0 &&
                   _pathIcon?.Length is not null;
        }
        
        private void CreateModel()
        {
            if (SelectedProduct is not null)
            {
                CreatedProduct = (ProductInfo) SelectedProduct.Clone();
            }

            BitmapFrame bitmapImage = null;
            byte[] photoByteArray = null;
            if (_pathIcon != null)
            {
                photoByteArray = File.ReadAllBytes(_pathIcon);
                using (var ms = new MemoryStream(photoByteArray))
                {
                    bitmapImage = BitmapFrame.Create(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }
            }
            
            using var unitOfWork = UnitOfWorkFactory.Create();
            var product = new ProductRepository(unitOfWork);
            var productId = product.Create(new Product
            {
                Name = CreatedProduct.Name,
                Price = CreatedProduct.Price,
                Weight = CreatedProduct.Weight
            });

            var icon = new IconRepository(unitOfWork);
            var iconId = icon.Create(new Icon
            {
                Photo = photoByteArray,
                ProductId = productId
            });
            
            unitOfWork.SaveChanges();
            CreatedProduct.Id = productId;
            CreatedProduct.IconId = iconId;
            CreatedProduct.Photo = bitmapImage;
            Products.Add(CreatedProduct);

            CreatedProduct = new ProductInfo();
        }
        
        private void UpdateModel()
        {
            BitmapFrame bitmapImage = null;
            byte[] photoByteArray = null;
            if (_pathIcon != null)
            {
                photoByteArray = File.ReadAllBytes(_pathIcon);
                using (var ms = new MemoryStream(photoByteArray))
                {
                    bitmapImage = BitmapFrame.Create(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }
            }
            
            using var unitOfWork = UnitOfWorkFactory.Create();
            var product = new ProductRepository(unitOfWork);
            product.Update(new Product
            {
                Id = CreatedProduct.Id,
                Name = CreatedProduct.Name,
                Price = CreatedProduct.Price,
                Weight = CreatedProduct.Weight
            });

            var icon = new IconRepository(unitOfWork);
            icon.Update(new Icon
            {
                Photo = photoByteArray,
                ProductId = CreatedProduct.IconId
            });
            
            unitOfWork.SaveChanges();
        }

        private void DeleteModel()
        {
            using var unitOfWork = UnitOfWorkFactory.Create();
            
            new IconRepository(unitOfWork).Delete(SelectedProduct.IconId);
            new ProductRepository(unitOfWork).Delete(SelectedProduct.Id);
            
            unitOfWork.SaveChanges();

            Products.Remove(SelectedProduct);
        }
        
        private void ChoosePhoto()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*",
                InitialDirectory = @"C:\"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _pathIcon = openFileDialog.FileName;
            }
        }

        #endregion
    }
}