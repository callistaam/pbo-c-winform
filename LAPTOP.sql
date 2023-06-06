-- create table
create table LAPTOP
(
	nama varchar (20) NOT NULL,
	harga int NOT NULL,
	stok int NOT NULL
)

-- test table
drop table LAPTOP
select * from LAPTOP

create table TRANSAKSI
(
	nama varchar (20) NOT NULL,
	alamat varchar (50) NOT NULL,
	No_Telepon varchar (16) NOT NULL,
	Tanggal_Transaksi date NOT NULL,
	Laptop_Yang_Dibeli varchar (50),
	Jumlah_Laptop_Yang_Dibeli varchar (3)
)

select * from TRANSAKSI

-- insert function
create function LAPTOP_INPUT(name character varying, harga integer, stok integer)
RETURNS integer AS
$$
BEGIN
    INSERT INTO LAPTOP(nama, harga, stok)
    VALUES(name, harga, stok);
    
    IF FOUND THEN
        RETURN 1;
    ELSE
        RETURN 0;
    END IF;
END;
$$
LANGUAGE plpgsql;

select * from LAPTOP_INPUT('ROG', 30000000, 1)