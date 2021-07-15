
		Create PROC SP_GetCustomerByString
		@string nvarchar(55)
		as
			Begin
				Select  Name, Phone, Email
				From CUSTOMERS
				Where Name like '%' + @string + '%' or Phone like '%' + @string + '%' or Email like '%' + @string + '%'
			End