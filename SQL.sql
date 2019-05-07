create table dbo.products(
  id int not null,
  name nvarchar(255) null,
  constraint pk_products_id primary key(id)
);

create table dbo.categories(
  id int not null,
  name nvarchar(255) null,
  constraint pk_categories_id primary key(id)
);

create table dbo.products_const(
  product_id int not null,
  category_id int not null,
  constraint fk_products_map_product_id foreign key (product_id) references dbo.products(id),
  constraint fk_products_map_category_id foreign key (category_id) references dbo.categories(id)
);

insert into dbo.categories (id, name) values 
	(1,'Электроника'), 
	(2,'Автомобили'), 
	(3,'Канцелярия')

insert into dbo.products (id, name) values  
	(1,'Телевизор'),
	(2,'Телефон'),
	(3,'Микроволновка'),
	(4,'BMW'),
	(5,'Audi'),
	(6,'Subaru'),
	(7,'Файл'),
	(8,'Ручка'),
	(9,'Никто это не читает'),
	(10,'Tesla'),
	(11,'Авторучка с подогревом'),
	(12,'Без категории'),
	(13, 'Клавиатура')

insert into dbo.products_const(product_id, category_id) values  
	(1,1),
	(2,1),
	(3,1),
	(4,2),
	(5,2),
	(6,2),
	(7,3),
	(8,3),
	(9,3),
	(10,2),
	(10,1),
	(11,1),
	(11,3),
	(13,1)

select 
	p.name + coalesce(' - ' + c.name,'') as [Name]
from 
	dbo.products p
left join 
	dbo.products_const 
on 
	p.id = products_const.product_id
left join 
	dbo.categories c 
on 
	products_const.category_id = c.id
	
drop table dbo.products_const
drop table dbo.products
drop table dbo.categories