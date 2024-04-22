--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

-- Started on 2024-04-21 21:04:27

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
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
-- TOC entry 216 (class 1259 OID 24778)
-- Name: books; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.books (
    book_id integer NOT NULL,
    title character varying(100) NOT NULL,
    first_name character varying(50) NOT NULL,
    last_name character varying(50) NOT NULL,
    total_copies integer DEFAULT 0 NOT NULL,
    copies_in_use integer DEFAULT 0 NOT NULL,
    type character varying(50),
    isbn character varying(80),
    category character varying(50)
);


ALTER TABLE public.books OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 24777)
-- Name: books_book_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.books_book_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.books_book_id_seq OWNER TO postgres;

--
-- TOC entry 4843 (class 0 OID 0)
-- Dependencies: 215
-- Name: books_book_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.books_book_id_seq OWNED BY public.books.book_id;


--
-- TOC entry 4688 (class 2604 OID 24781)
-- Name: books book_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books ALTER COLUMN book_id SET DEFAULT nextval('public.books_book_id_seq'::regclass);


--
-- TOC entry 4837 (class 0 OID 24778)
-- Dependencies: 216
-- Data for Name: books; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.books (book_id, title, first_name, last_name, total_copies, copies_in_use, type, isbn, category) FROM stdin;
1	Pride and Prejudice	Jane	Austen	100	80	Hardcover	1234567891	Fiction
2	To Kill a Mockingbird	Harper	Lee	75	65	Paperback	1234567892	Fiction
3	The Catcher in the Rye	J.D.	Salinger	50	45	Hardcover	1234567893	Fiction
4	The Great Gatsby	F. Scott	Fitzgerald	50	22	Hardcover	1234567894	Non-Fiction
5	The Alchemist	Paulo	Coelho	50	35	Hardcover	1234567895	Biography
6	The Book Thief	Markus	Zusak	75	11	Hardcover	1234567896	Mystery
7	The Chronicles of Narnia	C.S.	Lewis	100	14	Paperback	1234567897	Sci-Fi
8	The Da Vinci Code	Dan	Brown	50	40	Paperback	1234567898	Sci-Fi
9	The Grapes of Wrath	John	Steinbeck	50	35	Hardcover	1234567899	Fiction
10	The Hitchhiker's Guide to the Galaxy	Douglas	Adams	50	35	Paperback	1234567900	Non-Fiction
11	Moby-Dick	Herman	Melville	30	8	Hardcover	8901234567	Fiction
12	To Kill a Mockingbird	Harper	Lee	20	0	Paperback	9012345678	Non-Fiction
13	The Catcher in the Rye	J.D.	Salinger	10	1	Hardcover	0123456789	Non-Fiction
\.


--
-- TOC entry 4844 (class 0 OID 0)
-- Dependencies: 215
-- Name: books_book_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.books_book_id_seq', 13, true);


--
-- TOC entry 4692 (class 2606 OID 24785)
-- Name: books books_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_pkey PRIMARY KEY (book_id);


-- Completed on 2024-04-21 21:04:27

--
-- PostgreSQL database dump complete
--

