PGDMP      +            
    |            pbo_mvc    16.3    16.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    25299    pbo_mvc    DATABASE     �   CREATE DATABASE pbo_mvc WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE pbo_mvc;
                postgres    false            �            1259    25306    akun    TABLE     �   CREATE TABLE public.akun (
    id integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false            �            1259    25341    daftar_buku    TABLE     �   CREATE TABLE public.daftar_buku (
    id_buku integer NOT NULL,
    judul_buku character varying NOT NULL,
    tahun_terbit character varying NOT NULL,
    kategori character varying NOT NULL
);
    DROP TABLE public.daftar_buku;
       public         heap    postgres    false            �            1259    25340    daftar_buku_id_buku_seq    SEQUENCE     �   CREATE SEQUENCE public.daftar_buku_id_buku_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.daftar_buku_id_buku_seq;
       public          postgres    false    220            �           0    0    daftar_buku_id_buku_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.daftar_buku_id_buku_seq OWNED BY public.daftar_buku.id_buku;
          public          postgres    false    219            �            1259    25300    role    TABLE     e   CREATE TABLE public.role (
    id_role integer NOT NULL,
    nama_role character varying NOT NULL
);
    DROP TABLE public.role;
       public         heap    postgres    false            �            1259    25305    mahasiswa_id_seq    SEQUENCE     �   CREATE SEQUENCE public.mahasiswa_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.mahasiswa_id_seq;
       public          postgres    false    215                        0    0    mahasiswa_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.mahasiswa_id_seq OWNED BY public.role.id_role;
          public          postgres    false    216            �            1259    25311    prodi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.prodi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.prodi_id_seq;
       public          postgres    false    217                       0    0    prodi_id_seq    SEQUENCE OWNED BY     <   ALTER SEQUENCE public.prodi_id_seq OWNED BY public.akun.id;
          public          postgres    false    218            [           2604    25313    akun id    DEFAULT     c   ALTER TABLE ONLY public.akun ALTER COLUMN id SET DEFAULT nextval('public.prodi_id_seq'::regclass);
 6   ALTER TABLE public.akun ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    218    217            \           2604    25344    daftar_buku id_buku    DEFAULT     z   ALTER TABLE ONLY public.daftar_buku ALTER COLUMN id_buku SET DEFAULT nextval('public.daftar_buku_id_buku_seq'::regclass);
 B   ALTER TABLE public.daftar_buku ALTER COLUMN id_buku DROP DEFAULT;
       public          postgres    false    219    220    220            Z           2604    25312    role id_role    DEFAULT     l   ALTER TABLE ONLY public.role ALTER COLUMN id_role SET DEFAULT nextval('public.mahasiswa_id_seq'::regclass);
 ;   ALTER TABLE public.role ALTER COLUMN id_role DROP DEFAULT;
       public          postgres    false    216    215            �          0    25306    akun 
   TABLE DATA           6   COPY public.akun (id, username, password) FROM stdin;
    public          postgres    false    217   �       �          0    25341    daftar_buku 
   TABLE DATA           R   COPY public.daftar_buku (id_buku, judul_buku, tahun_terbit, kategori) FROM stdin;
    public          postgres    false    220   �       �          0    25300    role 
   TABLE DATA           2   COPY public.role (id_role, nama_role) FROM stdin;
    public          postgres    false    215   0                  0    0    daftar_buku_id_buku_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.daftar_buku_id_buku_seq', 3, true);
          public          postgres    false    219                       0    0    mahasiswa_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.mahasiswa_id_seq', 14, true);
          public          postgres    false    216                       0    0    prodi_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.prodi_id_seq', 3, true);
          public          postgres    false    218            b           2606    25346    daftar_buku daftar_buku_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.daftar_buku
    ADD CONSTRAINT daftar_buku_pkey PRIMARY KEY (id_buku);
 F   ALTER TABLE ONLY public.daftar_buku DROP CONSTRAINT daftar_buku_pkey;
       public            postgres    false    220            `           2606    25317    akun prodi_pkey 
   CONSTRAINT     M   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT prodi_pkey PRIMARY KEY (id);
 9   ALTER TABLE ONLY public.akun DROP CONSTRAINT prodi_pkey;
       public            postgres    false    217            ^           2606    25361    role role_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.role
    ADD CONSTRAINT role_pkey PRIMARY KEY (id_role);
 8   ALTER TABLE ONLY public.role DROP CONSTRAINT role_pkey;
       public            postgres    false    215            c           2606    25372    role role_id_role_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.role
    ADD CONSTRAINT role_id_role_fkey FOREIGN KEY (id_role) REFERENCES public.role(id_role) NOT VALID;
 @   ALTER TABLE ONLY public.role DROP CONSTRAINT role_id_role_fkey;
       public          postgres    false    215    215    4702            �      x������ � �      �   4   x�3�t*�.U������4204�3��!���E� asN�ĬĜ��=... ���      �       x�3�H�KO/�K�2�tL�������� W�P     