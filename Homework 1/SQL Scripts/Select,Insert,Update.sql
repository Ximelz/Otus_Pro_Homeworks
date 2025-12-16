--Добавление продукта
INSERT INTO "Products" ("ProductID", "ProductName", "Description", "Price", "QuantityInStock")
	VALUES (gen_random_uuid()::uuid, 'Some product name', 'Some description', random(1, 1000)::bigint, random(1, 30)::bigint)

--Обвновление цены продукта
UPDATE "Products"
	SET "Price" = random(1, 1000)::bigint
	WHERE "ProductID" = 'fd6d3a71-774e-4fb0-a04d-58268b8bef6e'

--Выбор всех заказов определенного пользователя
SELECT "OrderID", "OrderDate", "Status"
	FROM "Orders"
	WHERE "UserID" = '291d6a09-2ce2-48c8-bad7-8264e6f30820'

--Расчет общей стоимости заказа
SELECT SUM("TotalCost")
	FROM "OrderDetails"
	WHERE "OrderID" = '33876f59-cec8-4c2b-9e65-f3d6b8c4023b'

--Подсчет количества товаров на складе
SELECT "ProductName", "QuantityInStock"
	FROM "Products"
	WHERE "ProductID" = 'ee2be37b-2539-4acd-b74e-2e8b6e9a3fa7'

--Получение 5 самых дорогих товаров
SELECT "ProductName", "QuantityInStock", "Description", "Price"
	FROM "Products"
	ORDER BY "Price" DESC
	LIMIT 5

--Список товаров с низким запасом (менее 5 штук)
SELECT "ProductName", "Description", "Price", "QuantityInStock"
	FROM "Products"
	WHERE "QuantityInStock" < 5