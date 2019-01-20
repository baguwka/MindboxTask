create table public.Products
(
	product_id integer,
    name character varying
);

create table public.Categories
(
	category_id integer,
    name character varying
);

create table public.Products_Categories
(
    product_id integer,
    category_id integer
);

INSERT INTO public.products(product_id, name) VALUES (1, 'acer swift');
INSERT INTO public.products(product_id, name) VALUES (2, 'silly photo');
INSERT INTO public.products(product_id, name) VALUES (3, 'dodo book');
INSERT INTO public.products(product_id, name) VALUES (4, 'switch gamepad');
INSERT INTO public.products(product_id, name) VALUES (5, 'prediction ball');
INSERT INTO public.products(product_id, name) VALUES (6, 'iphone 96');
INSERT INTO public.products(product_id, name) VALUES (7, 'red pillow');
INSERT INTO public.products(product_id, name) VALUES (8, 'yellow pillow');
INSERT INTO public.products(product_id, name) VALUES (9, 'cheese');
INSERT INTO public.products(product_id, name) VALUES (10, 'notepad');
INSERT INTO public.products(product_id, name) VALUES (11, 'tomatoes');
INSERT INTO public.products(product_id, name) VALUES (12, 'ps4');
INSERT INTO public.products(product_id, name) VALUES (13, 'headphones');

INSERT INTO public.categories(category_id, name) VALUES (1, 'food');
INSERT INTO public.categories(category_id, name) VALUES (2, 'books');
INSERT INTO public.categories(category_id, name) VALUES (3, 'devices');
INSERT INTO public.categories(category_id, name) VALUES (4, 'textile');

INSERT INTO public.products_categories(product_id, category_id) VALUES (9, 1);
INSERT INTO public.products_categories(product_id, category_id) VALUES (11, 1);
INSERT INTO public.products_categories(product_id, category_id) VALUES (3, 2);
INSERT INTO public.products_categories(product_id, category_id) VALUES (10, 2);
INSERT INTO public.products_categories(product_id, category_id) VALUES (1, 3);
INSERT INTO public.products_categories(product_id, category_id) VALUES (4, 3);
INSERT INTO public.products_categories(product_id, category_id) VALUES (6, 3);
INSERT INTO public.products_categories(product_id, category_id) VALUES (12, 3);
INSERT INTO public.products_categories(product_id, category_id) VALUES (13, 3);

select p.name as productName, c.name as categoryName
from products_categories as p_c
inner join categories as c
   on p_c.category_id = c.category_id
right join products as p
   on p.product_id = p_c.product_id
order by categoryname

