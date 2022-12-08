using ShoppingCart.Implementation;
using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingFacade
{
    public class UserOrder : IUserOrder
    {
        public int AddToCart(int itemId, int qty)
        {
            Console.WriteLine("Start AddToCart");
            ICart userCart = new ShoppingCartDetails();
            int cartID = 0;
            Product product = userCart.GetItemDetails(itemId);
            
            if (userCart.CheckItemAvailability(product))
            {
                userCart.LockItemInStock(itemId, qty);
                cartID = userCart.AddItemToCart(itemId, qty);
            }
            
            Console.WriteLine("End AddToCart");
            return cartID;
        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start PlaceOrderDetails");
            int orderID = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            ICart userCart = new ShoppingCartDetails();
            IAddress address = new AddressDetails();
            IOrder order = new Order();

            double stateTax = tax.GetTaxByState("ABC");

            tax.ApplyTax(cartID, stateTax);

            double userWalletBalance = wallet.GetUserBalance(userID);
            double cartPrice = userCart.GetCartPrice(cartID);

            if (userWalletBalance > cartPrice)
            {
                Address userAddress = address.GetAddressDetails(userID);
                orderID = order.PlaceOrderDetails(cartID, userAddress.AddressID);

            }
            Console.WriteLine("End PlaceOrderDetails");
            return orderID;
        }
    }
}