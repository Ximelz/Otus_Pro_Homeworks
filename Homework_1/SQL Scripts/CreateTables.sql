CREATE TABLE "Users"
(
	"UserID" uuid PRIMARY KEY,
	"UserName" varchar(100) NOT NULL,
	"Email" varchar(100),
	"RegistrationDate" data DEFAULT CURRENT_DATE
);

CREATE TABLE "Products"
(
	"ProductID" uuid PRIMARY KEY,
	"ProductName" varchar(100) NOT NULL,
	"Description" varchar(100),
	"Price" bigint NOT NULL DEFAULT 0,
	"QuantityInStock" int NOT NULL DEFAULT 0
);

CREATE TABLE "Orders"
(
	"OrderID" uuid PRIMARY KEY,
	"UserID" uuid NOT NULL,
	"OrderDate" data DEFAULT CURRENT_DATE,
	"Status" int NOT NULL DEFAULT 0,
	
	CONSTRAINT "Oder_UserID"
        FOREIGN KEY ("UserID") 
        REFERENCES "Users"("UserID")
);

CREATE TABLE "OrderDetails"
(
	"OrderDetailID" uuid PRIMARY KEY,
	"OrderID" uuid NOT NULL,
	"ProductID" uuid NOT NULL,
	"Quantity" int NOT NULL,
	"TotalCost" int NOT NULL,
	
	CONSTRAINT "OderDet_OderID"
        FOREIGN KEY ("OrderID") 
        REFERENCES "Orders"("OrderID"),
		
	CONSTRAINT "OderDet_ProductID"
        FOREIGN KEY ("ProductID") 
        REFERENCES "Products"("ProductID")
);
