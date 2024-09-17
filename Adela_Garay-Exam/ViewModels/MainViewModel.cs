using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenMvvm.Models;

namespace ExamenMvvm.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ProductModel _productModel = new ProductModel();

        public decimal Product1
        {
            get => _productModel.Product1;
            set
            {
                if (_productModel.Product1 != value)
                {
                    _productModel.Product1 = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Subtotal));
                    OnPropertyChanged(nameof(Discount));
                    OnPropertyChanged(nameof(TotalToPay));
                }
            }
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public decimal Product2
        {
            get => _productModel.Product2;
            set
            {
                if (_productModel.Product2 != value)
                {
                    _productModel.Product2 = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Subtotal));
                    OnPropertyChanged(nameof(Discount));
                    OnPropertyChanged(nameof(TotalToPay));
                }
            }
        }

        public decimal Product3
        {
            get => _productModel.Product3;
            set
            {
                if (_productModel.Product3 != value)
                {
                    _productModel.Product3 = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Subtotal));
                    OnPropertyChanged(nameof(Discount));
                    OnPropertyChanged(nameof(TotalToPay));
                }
            }
        }

        public decimal Subtotal => _productModel.Subtotal;
        public decimal Discount => _productModel.Discount;
        public decimal TotalToPay => _productModel.TotalToPay;

        [ICommand]
        private void Calculate()
        {
            OnPropertyChanged(nameof(Subtotal));
            OnPropertyChanged(nameof(Discount));
            OnPropertyChanged(nameof(TotalToPay));
        }

        [ICommand]
        private void Clear()
        {
            Product1 = 0;
            Product2 = 0;
            Product3 = 0;
        }
    }

    internal class ICommandAttribute : Attribute
    {
    }

    public class ObservableObject
    {
    }
}

