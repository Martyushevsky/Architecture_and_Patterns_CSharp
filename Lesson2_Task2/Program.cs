namespace Lesson2_Task2
{
    class Color { }
    class Size { }

    interface IItem
    {
        void SetPrice(double price);
    }
    interface IDifferentSizesItem : IItem
    {
        void SetSize(Size size);
    }
    interface IDifferentColorsItem : IItem
    {
        void SetColor(Color color);
    }
    interface IDiscountableItem : IItem
    {
        void SetDiscount(double discount);
        void SetPromocode(string promocode);
    }

    class Car : IDifferentColorsItem
    {
        public void SetColor(Color color) { }
        public void SetPrice(double price) { }
    }

    class Book : IDiscountableItem
    {
        public void SetDiscount(double discount) { }
        public void SetPromocode(string promocode) { }
        public void SetPrice(double price) { }
    }

    class Clothes : IDiscountableItem, IDifferentSizesItem, IDifferentColorsItem
    {
        public void SetDiscount(double discount) { }
        public void SetPromocode(string promocode) { }
        public void SetSize(Size size) { }
        public void SetColor(Color color) { }
        public void SetPrice(double price) { }
    }
}