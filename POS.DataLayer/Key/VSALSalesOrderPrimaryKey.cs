//
// Class	:	VSALSalesOrderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/19/2015 1:00:17 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class VSALSalesOrderPrimaryKey
	{

	#region Class Level Variables
			private int?           	_customerIDNonDefault    	= null;
		private int?           	_salesLineIDNonDefault   	= null;
		private int?           	_salesHeaderIDNonDefault 	= null;
		private int?           	_productIDNonDefault     	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public VSALSalesOrderPrimaryKey(int? customerID,int? salesLineID,int? salesHeaderID,int? productID) 
		{
	
			
			this._customerIDNonDefault = customerID;
			
			this._salesLineIDNonDefault = salesLineID;
			
			this._salesHeaderIDNonDefault = salesHeaderID;
			
			this._productIDNonDefault = productID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "CustomerID" field.  Mandatory.
		/// </summary>
		public int? CustomerID
		{
			get 
			{ 
				return _customerIDNonDefault;
			}
			set 
			{
			
				_customerIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "SalesLineID" field.  Mandatory.
		/// </summary>
		public int? SalesLineID
		{
			get 
			{ 
				return _salesLineIDNonDefault;
			}
			set 
			{
			
				_salesLineIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "SalesHeaderID" field.  Mandatory.
		/// </summary>
		public int? SalesHeaderID
		{
			get 
			{ 
				return _salesHeaderIDNonDefault;
			}
			set 
			{
			
				_salesHeaderIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductID" field.  Mandatory.
		/// </summary>
		public int? ProductID
		{
			get 
			{ 
				return _productIDNonDefault;
			}
			set 
			{
			
				_productIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/19/2015 1:00:17 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("CustomerID",_customerIDNonDefault.ToString());
			nvc.Add("SalesLineID",_salesLineIDNonDefault.ToString());
			nvc.Add("SalesHeaderID",_salesHeaderIDNonDefault.ToString());
			nvc.Add("ProductID",_productIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
