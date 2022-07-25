                                   --ASSIGNMENT4--
SELECT * FROM CUSTOMER

SELECT * FROM EMPLOYEE

SELECT * FROM [ORDER ]

SELECT * FROM PRODUCT

SELECT * FROM SHIP

SELECT * FROM STOCK

SELECT PRODUCT.SUPPLIERS,PRODUCT.[UNIT-PRICE] AS TOTALPRICE ,SHIP.[SHIPPING-COMPANY] FROM PRODUCT
INNER JOIN SHIP ON SHIP.[SHIP-NAME]=PRODUCT.[SHIP-NAME]
WHERE PRODUCT.SUPPLIERS = 'EXOTIC LIQUIDS' AND PRODUCT.[UNIT-PRICE] >50

SELECT PRODUCT.SUPPLIERS,PRODUCT.[UNIT-PRICE] AS TOTALPRICE ,SHIP.[SHIPPING-COMPANY] FROM PRODUCT
INNER JOIN SHIP ON SHIP.[SHIP-NAME]=PRODUCT.[SHIP-NAME]
WHERE PRODUCT.SUPPLIERS = 'EXOTIC LIQUIDS' AND PRODUCT.[UNIT-PRICE] >10

SELECT * FROM EMPLOYEE ORDER BY [JOINING-DATE] ASC

SELECT * FROM EMPLOYEE ORDER BY [JOINING-DATE] DESC

SELECT [PRODUCT-NAME],[UNIT-PRICE] FROM PRODUCT ORDER BY [UNIT-PRICE] DESC

SELECT [PRODUCT-NAME],[UNIT-PRICE] FROM PRODUCT ORDER BY [UNIT-PRICE] ASC

SELECT [PRODUCT-NAME],[UNIT-PRICE]
FROM PRODUCT
WHERE[UNIT-PRICE] = (SELECT MAX([UNIT-PRICE]) FROM  PRODUCT ) 
OR [UNIT-PRICE] = (SELECT MIN([UNIT-PRICE]) FROM PRODUCT)

SELECT * FROM STOCK WHERE [STATUS] = 'OUT-OF-STOCK'

SELECT * FROM STOCK WHERE STOCK.[UNIT-IN-STOCK] < STOCK.[UNIT-IN-ORDER]

SELECT CATEGORY,SUPPLIERS FROM PRODUCT

SELECT CONCAT(CUSTOMER.[FIRST-NAME],' ',CUSTOMER.[LAST-NAME]) AS [CUSTOMER-NAME],[ORDER ].[ORDER-DATE],ORDERITEM.[ORDER-ID],PRODUCT.[PRODUCT-NAME] FROM PRODUCT
INNER JOIN ORDERITEM ON ORDERITEM.[PRODUCT-ID]=PRODUCT.[PRODUCT-ID]
INNER JOIN [ORDER ] ON [ORDER ].[ORDER-ID]=ORDERITEM.[ORDER-ID]
INNER JOIN CUSTOMER ON CUSTOMER.[CUSTOMER-ID]=[ORDER ].[CUSTOMER-ID]

SELECT CONCAT(CUSTOMER.[FIRST-NAME],' ',CUSTOMER.[LAST-NAME]) AS [CUSTOMER-NAME],ORDERITEM.QUANTITY AS [NO.OF ORDERS] FROM ORDERITEM
INNER JOIN [ORDER ] ON [ORDER ].[ORDER-ID]=ORDERITEM.[ORDER-ID]
INNER JOIN CUSTOMER ON CUSTOMER.[CUSTOMER-ID]=[ORDER ].[CUSTOMER-ID]
WHERE ORDERITEM.QUANTITY=(SELECT MAX(QUANTITY) FROM ORDERITEM)
 
SELECT * FROM CUSTOMER WHERE SUBSTRING([FIRST-NAME],1,2)='RA'

SELECT SUBSTRING([SHIPPING-COMPANY],1,1) AS [FIRST-LETTER-OF-COMPANY],[SHIPPING-COMPANY] FROM SHIP
