toc.dat                                                                                             0000600 0004000 0002000 00000002556 14713364452 0014460 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP       "            
    |            TaskManagement    17rc1    17rc1     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false         �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false         �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false         �           1262    16530    TaskManagement    DATABASE     �   CREATE DATABASE "TaskManagement" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
     DROP DATABASE "TaskManagement";
                     postgres    false         �            1259    16531    tugas    TABLE     �   CREATE TABLE public.tugas (
    judul character varying(64) NOT NULL,
    deskripsi character varying(64) NOT NULL,
    deadline character varying(64) NOT NULL
);
    DROP TABLE public.tugas;
       public         heap r       postgres    false         �          0    16531    tugas 
   TABLE DATA           ;   COPY public.tugas (judul, deskripsi, deadline) FROM stdin;
    public               postgres    false    217       4839.dat                                                                                                                                                  4839.dat                                                                                            0000600 0004000 0002000 00000000005 14713364452 0014265 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           restore.sql                                                                                         0000600 0004000 0002000 00000003621 14713364452 0015377 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 17rc1
-- Dumped by pg_dump version 17rc1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE "TaskManagement";
--
-- Name: TaskManagement; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "TaskManagement" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';


ALTER DATABASE "TaskManagement" OWNER TO postgres;

\connect "TaskManagement"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: tugas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tugas (
    judul character varying(64) NOT NULL,
    deskripsi character varying(64) NOT NULL,
    deadline character varying(64) NOT NULL
);


ALTER TABLE public.tugas OWNER TO postgres;

--
-- Data for Name: tugas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tugas (judul, deskripsi, deadline) FROM stdin;
\.
COPY public.tugas (judul, deskripsi, deadline) FROM '$$PATH$$/4839.dat';

--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               