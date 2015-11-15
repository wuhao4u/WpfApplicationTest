using System;

namespace GenericSample
{
	// generic method for all product types
	public class DiscountCalculator<TProduct> where TProduct : Product
	{
		public float CalculateDiscount(TProduct product)
		{
			return product.Price;
		}
	}
}

