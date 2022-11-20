PGDMP         -            
    z            mamodb    15.1    15.1 "               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                        1262    16398    mamodb    DATABASE     }   CREATE DATABASE mamodb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE mamodb;
                postgres    false            �            1255    16522     budget_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.budget_delete(_id_budget character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	delete from public.tb_budget
	where id_budget=_id_budget;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 B   DROP FUNCTION public.budget_delete(_id_budget character varying);
       public          postgres    false            �            1255    16598 L   budget_insert(character varying, real, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.budget_insert(_category character varying, _nominal real, _tanggalawal character varying, _tanggalakhir character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	insert into public.tb_budget
	(
		category,
		nominal,
		tanggalAwal,
		tanggalAkhir
	)
	values
	(
		_category,
		_nominal,
		TO_DATE(_tanggalAwal, "DD/MM/YYYY"),
		TO_DATE(_tanggalAkhir, "DD/MM/YYYY")
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.budget_insert(_category character varying, _nominal real, _tanggalawal character varying, _tanggalakhir character varying);
       public          postgres    false            �            1255    16596    budget_select()    FUNCTION     1  CREATE FUNCTION public.budget_select() RETURNS TABLE(_id_budget character varying, _category character varying, _nominal real, _tanggalawal date, _tanggalakhir date)
    LANGUAGE plpgsql
    AS $$
BEGIN
	return query
	select id_budget, category, nominal, tanggalAwal, tanggalAkhir from tb_budget;
end
$$;
 &   DROP FUNCTION public.budget_select();
       public          postgres    false            �            1255    16595 _   budget_update(character varying, character varying, real, character varying, character varying)    FUNCTION       CREATE FUNCTION public.budget_update(_id_budget character varying, _category character varying, _nominal real, _tanggalawal character varying, _tanggalakhir character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	update tb_transactions SET
		type=_type,
		category=_category,
		notes=_notes,
		source=_source,
		nominal=_nominal,
		tanggalAwal=TO_DATE(_tanggalAwal, "DD/MM/YYYY"),
		tanggalAkhir=TO_DATE(_tanggalAkhir, "DD/MM/YYYY")
	where id_budget=_id_budget;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.budget_update(_id_budget character varying, _category character varying, _nominal real, _tanggalawal character varying, _tanggalakhir character varying);
       public          postgres    false            �            1255    16518 &   transactions_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.transactions_delete(_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	delete from public.tb_transactions
	where id=_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 A   DROP FUNCTION public.transactions_delete(_id character varying);
       public          postgres    false            �            1255    16589 x   transactions_insert(character varying, character varying, character varying, character varying, real, character varying)    FUNCTION     �  CREATE FUNCTION public.transactions_insert(_type character varying, _category character varying, _notes character varying, _source character varying, _nominal real, _date character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	insert into public.tb_transactions
	(
		nominal,
		type,
		category,
		notes,
		date,
		source
	)
	values
	(
		_nominal,
		_type,
		_category,
		_notes,
		TO_DATE(_date, 'DD/MM/YYYY'),
		_source
	);
	update tb_budget set
	nominal = nominal + nominal.tb_transactions
	where
	category.tb_budget == category.tb_transactions and 
	date.tb_transactions >= tanggalAwal.tb_budget and 
	date.tb_transactions <= tanggalAkhir.tb_budget;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.transactions_insert(_type character varying, _category character varying, _notes character varying, _source character varying, _nominal real, _date character varying);
       public          postgres    false            �            1255    16591    transactions_select()    FUNCTION     b  CREATE FUNCTION public.transactions_select() RETURNS TABLE(_id character varying, _type character varying, _category character varying, _notes character varying, _source character varying, _nominal real, _date date)
    LANGUAGE plpgsql
    AS $$
BEGIN
	return query
	select id, type, category, notes, source, nominal, date from tb_transactions;
end
$$;
 ,   DROP FUNCTION public.transactions_select();
       public          postgres    false            �            1255    16594 �   transactions_update(character varying, character varying, character varying, character varying, character varying, real, character varying)    FUNCTION     �  CREATE FUNCTION public.transactions_update(_id character varying, _type character varying, _category character varying, _notes character varying, _source character varying, _nominal real, _date character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	update tb_transactions SET
		type=_type,
		category=_category,
		notes=_notes,
		source=_source,
		nominal=_nominal,
		date=TO_DATE(_date, "DD/MM/YYYY")
	where id=_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.transactions_update(_id character varying, _type character varying, _category character varying, _notes character varying, _source character varying, _nominal real, _date character varying);
       public          postgres    false            �            1255    16523    user_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.user_delete(_id_user character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	delete from public.tb_user
	where id_user=_id_user;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 >   DROP FUNCTION public.user_delete(_id_user character varying);
       public          postgres    false            �            1255    16526 D   user_insert(character varying, character varying, character varying)    FUNCTION     [  CREATE FUNCTION public.user_insert(_name character varying, _email character varying, _passsword character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	insert into public.tb_transactions
	(
		name,
		email,
		password
	)
	values
	(
		_name,
		_email,
		_password
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 s   DROP FUNCTION public.user_insert(_name character varying, _email character varying, _passsword character varying);
       public          postgres    false            �            1255    16593    user_select()    FUNCTION       CREATE FUNCTION public.user_select() RETURNS TABLE(_id_user character varying, _name character varying, _email character varying, _password character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
	return query
	select id_user, name, email, password from tb_user;
end
$$;
 $   DROP FUNCTION public.user_select();
       public          postgres    false            �            1255    16592 W   user_update(character varying, character varying, character varying, character varying)    FUNCTION     b  CREATE FUNCTION public.user_update(_id_user character varying, _name character varying, _email character varying, _password character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
	update tb_user SET
		name=_name,
		email=_email,
		password=_password
	where id_user=_id_user;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.user_update(_id_user character varying, _name character varying, _email character varying, _password character varying);
       public          postgres    false            �            1259    16403    id    SEQUENCE     k   CREATE SEQUENCE public.id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.id;
       public          postgres    false            �            1259    16416 	   id_budget    SEQUENCE     r   CREATE SEQUENCE public.id_budget
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
     DROP SEQUENCE public.id_budget;
       public          postgres    false            �            1259    16425    id_user    SEQUENCE     p   CREATE SEQUENCE public.id_user
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.id_user;
       public          postgres    false            �            1259    16417 	   tb_budget    TABLE       CREATE TABLE public.tb_budget (
    id_budget character varying(10) DEFAULT (''::text || nextval('public.id_budget'::regclass)) NOT NULL,
    category character varying,
    fk_user character varying(10),
    nominal real,
    "tanggalAwal" date,
    "tanggalAkhir" date
);
    DROP TABLE public.tb_budget;
       public         heap    postgres    false    216            �            1259    16404    tb_transactions    TABLE     h  CREATE TABLE public.tb_transactions (
    id character varying(10) DEFAULT (''::text || nextval('public.id'::regclass)) NOT NULL,
    type character varying(20),
    category character varying,
    notes character varying,
    source character varying,
    fk_user character varying(10),
    fk_budget character varying(10),
    nominal real,
    date date
);
 #   DROP TABLE public.tb_transactions;
       public         heap    postgres    false    214            �            1259    16426    tb_user    TABLE     �   CREATE TABLE public.tb_user (
    id_user character varying(10) DEFAULT (''::text || nextval('public.id_user'::regclass)) NOT NULL,
    name character varying(50),
    email character varying(20),
    password character varying
);
    DROP TABLE public.tb_user;
       public         heap    postgres    false    218                      0    16417 	   tb_budget 
   TABLE DATA           i   COPY public.tb_budget (id_budget, category, fk_user, nominal, "tanggalAwal", "tanggalAkhir") FROM stdin;
    public          postgres    false    217   �8                 0    16404    tb_transactions 
   TABLE DATA           o   COPY public.tb_transactions (id, type, category, notes, source, fk_user, fk_budget, nominal, date) FROM stdin;
    public          postgres    false    215   �8                 0    16426    tb_user 
   TABLE DATA           A   COPY public.tb_user (id_user, name, email, password) FROM stdin;
    public          postgres    false    219   J9       !           0    0    id    SEQUENCE SET     1   SELECT pg_catalog.setval('public.id', 11, true);
          public          postgres    false    214            "           0    0 	   id_budget    SEQUENCE SET     8   SELECT pg_catalog.setval('public.id_budget', 1, false);
          public          postgres    false    216            #           0    0    id_user    SEQUENCE SET     6   SELECT pg_catalog.setval('public.id_user', 1, false);
          public          postgres    false    218            �           2606    16424    tb_budget tb_budget_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.tb_budget
    ADD CONSTRAINT tb_budget_pkey PRIMARY KEY (id_budget);
 B   ALTER TABLE ONLY public.tb_budget DROP CONSTRAINT tb_budget_pkey;
       public            postgres    false    217                       2606    16411 $   tb_transactions tb_transactions_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.tb_transactions
    ADD CONSTRAINT tb_transactions_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.tb_transactions DROP CONSTRAINT tb_transactions_pkey;
       public            postgres    false    215            �           2606    16433    tb_user tb_user_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.tb_user
    ADD CONSTRAINT tb_user_pkey PRIMARY KEY (id_user);
 >   ALTER TABLE ONLY public.tb_user DROP CONSTRAINT tb_user_pkey;
       public            postgres    false    219            �           2606    16439    tb_transactions fk_budget    FK CONSTRAINT     �   ALTER TABLE ONLY public.tb_transactions
    ADD CONSTRAINT fk_budget FOREIGN KEY (fk_budget) REFERENCES public.tb_budget(id_budget) NOT VALID;
 C   ALTER TABLE ONLY public.tb_transactions DROP CONSTRAINT fk_budget;
       public          postgres    false    217    3201    215            �           2606    16434    tb_transactions fk_user    FK CONSTRAINT     �   ALTER TABLE ONLY public.tb_transactions
    ADD CONSTRAINT fk_user FOREIGN KEY (fk_user) REFERENCES public.tb_user(id_user) NOT VALID;
 A   ALTER TABLE ONLY public.tb_transactions DROP CONSTRAINT fk_user;
       public          postgres    false    219    215    3203            �           2606    16444    tb_budget fk_user    FK CONSTRAINT     �   ALTER TABLE ONLY public.tb_budget
    ADD CONSTRAINT fk_user FOREIGN KEY (fk_user) REFERENCES public.tb_user(id_user) NOT VALID;
 ;   ALTER TABLE ONLY public.tb_budget DROP CONSTRAINT fk_user;
       public          postgres    false    217    219    3203                  x������ � �         {   x�3�H�KO�)M,J��t�M��,I-6�t�O��I-��#.s��I� �ބ�)1/E�HmJbAb	�Ҭ��$t��@�u8��$�e%rr���%f"+5202�54�52������ s�7n            x������ � �     