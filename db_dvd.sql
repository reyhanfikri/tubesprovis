-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2018 at 02:29 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_dvd`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_customer`
--

CREATE TABLE `tb_customer` (
  `id_cust` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_customer',
  `nama_cust` varchar(100) NOT NULL COMMENT 'nama pembeli',
  `username` varchar(100) NOT NULL COMMENT 'username pembeli yang dapat digunakan untuk log in',
  `email` varchar(100) NOT NULL COMMENT 'email pembeli yang dapat digunakan untuk log in',
  `password` varchar(100) NOT NULL COMMENT 'password pembeli yang digunakan untuk log in'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_customer`
--

INSERT INTO `tb_customer` (`id_cust`, `nama_cust`, `username`, `email`, `password`) VALUES
(1, 'Ammar A', 'Ammar', 'ammar@gmail.com', 'ammara123'),
(2, 'IGN Agung AAW', 'Agung', 'ignagung@gmail.com', 'qwerty'),
(3, 'Reyhan Fikri', 'Reyhan', 'reyhanf@gmail.com', '000001'),
(4, 'Rifky Syswanto', 'Rifky', 'rifkysyswanto@gmail.com', '0258'),
(5, 'Andy Batary FN', 'Tary', 'tary@gmail.com', '14789632'),
(6, 'Winda Mauli', 'winda', 'windamk@gmail.com', 'wndmk'),
(7, 'Muhammad Budi', 'Budi', 'mbudi@gmail.com', 'budi444'),
(8, 'Ahmad Asep', 'Ahmad', 'aasep@gmail.com', '11111'),
(9, 'Siti Hawa', 'siha', 'sihawa@gmail.com', 'sihaaaa'),
(10, 'Nur Intan', 'Intan', 'nintan@gmail.com', 'intan101');

-- --------------------------------------------------------

--
-- Table structure for table `tb_detail_keranjang`
--

CREATE TABLE `tb_detail_keranjang` (
  `id_detail` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_detail_keranjang',
  `id_keranjang` int(11) NOT NULL COMMENT 'menghubungkan data dengan tabel tb_keranjang',
  `id_dvd` int(11) NOT NULL COMMENT 'menghubungkan data dengan tabel tb_dvd',
  `qty` int(11) NOT NULL COMMENT 'jumlah dvd yang dibeli',
  `harga_jual` int(11) NOT NULL COMMENT 'Harga kenyataan yang dijual ke pembeli',
  `total_harga` int(11) NOT NULL COMMENT 'Total harga dvd yang dibeli'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_detail_keranjang`
--

INSERT INTO `tb_detail_keranjang` (`id_detail`, `id_keranjang`, `id_dvd`, `qty`, `harga_jual`, `total_harga`) VALUES
(1, 1, 1, 1, 52000, 52000),
(2, 2, 2, 1, 50000, 50000),
(3, 3, 3, 2, 65000, 130000),
(4, 4, 4, 1, 55000, 55000),
(5, 5, 10, 3, 55000, 165000),
(6, 6, 13, 2, 40000, 80000),
(7, 7, 7, 1, 55000, 55000),
(8, 8, 17, 2, 63500, 127000),
(9, 9, 11, 4, 55000, 220000),
(10, 10, 14, 1, 60000, 60000),
(11, 11, 8, 1, 60000, 60000),
(12, 12, 9, 2, 54000, 108000),
(13, 13, 18, 5, 64500, 322500),
(14, 14, 20, 1, 52500, 52500),
(15, 15, 17, 63500, 2, 127000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_dvd`
--

CREATE TABLE `tb_dvd` (
  `id_dvd` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_dvd',
  `id_movie` int(11) NOT NULL COMMENT 'menghubungkan data dengan tabel tb_movie',
  `stock` int(11) NOT NULL COMMENT 'Informasi mengenai jumlah stock dvd yang tersedia',
  `harga_display` int(11) NOT NULL COMMENT 'informasi mengenai harga yang ada di display'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_dvd`
--

INSERT INTO `tb_dvd` (`id_dvd`, `id_movie`, `stock`, `harga_display`) VALUES
(1, 1, 10, 52000),
(2, 2, 12, 50000),
(3, 3, 5, 65000),
(4, 4, 5, 55000),
(5, 5, 15, 66000),
(6, 6, 8, 62000),
(7, 7, 10, 55000),
(8, 8, 5, 60000),
(9, 9, 7, 54000),
(10, 10, 2, 80000),
(11, 11, 5, 60000),
(12, 12, 3, 75000),
(13, 13, 6, 40000),
(14, 14, 10, 60000),
(15, 15, 8, 65000),
(16, 16, 4, 40000),
(17, 17, 6, 63500),
(18, 18, 15, 64500),
(19, 19, 4, 53400),
(20, 20, 8, 52500);

-- --------------------------------------------------------

--
-- Table structure for table `tb_gambar_dvd`
--

CREATE TABLE `tb_gambar_dvd` (
  `id_gambar` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_gambar_dvd',
  `id_dvd` int(11) NOT NULL COMMENT 'menghubungkan data yang ada di tabel tb_dvd',
  `id_movie` int(11) NOT NULL,
  `url_gambar` varchar(200) NOT NULL COMMENT 'url gambar dvd'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_gambar_dvd`
--

INSERT INTO `tb_gambar_dvd` (`id_gambar`, `id_dvd`, `id_movie`, `url_gambar`) VALUES
(1, 1, 1, 'https://upload.wikimedia.org/wikipedia/id/b/be/Thor_Ragnarok_poster_2.jpg'),
(2, 2, 2, 'https://upload.wikimedia.org/wikipedia/id/e/ed/Wonder_Woman_%282017_film%29.jpg'),
(3, 3, 3, 'https://upload.wikimedia.org/wikipedia/id/d/d7/Coco_%282017_film%29_logo.jpg'),
(4, 4, 4, 'https://upload.wikimedia.org/wikipedia/id/7/7d/The_Post_Steven_Spielberg_Poster_2017.jpg'),
(5, 5, 5, 'https://upload.wikimedia.org/wikipedia/id/d/d6/Beauty_and_the_Beast_2017_poster.jpg'),
(6, 6, 6, 'https://upload.wikimedia.org/wikipedia/id/6/65/IT_Bill_Skarsgard_Poster_2017.jpg'),
(7, 7, 7, 'https://upload.wikimedia.org/wikipedia/id/2/2a/LOTRTTTmovie.jpg'),
(8, 8, 8, 'https://upload.wikimedia.org/wikipedia/id/8/8a/Dark_Knight.jpg'),
(9, 9, 9, 'https://upload.wikimedia.org/wikipedia/id/4/4d/Catch_Me_If_You_Can_2002_movie.jpg'),
(10, 10, 10, 'https://upload.wikimedia.org/wikipedia/id/8/87/StarWarsMoviePoster1977.jpg'),
(11, 11, 11, 'https://upload.wikimedia.org/wikipedia/id/9/91/Inception_poster.jpg'),
(12, 12, 12, 'https://upload.wikimedia.org/wikipedia/id/4/4b/Titanic_film.jpg'),
(13, 13, 13, 'https://upload.wikimedia.org/wikipedia/id/1/1c/Nemo-poster2.jpg'),
(14, 14, 14, 'https://upload.wikimedia.org/wikipedia/id/1/17/Laskar_Pelangi_film.jpg'),
(15, 15, 15, 'https://upload.wikimedia.org/wikipedia/id/7/74/Habibie_Ainun_Poster.jpg'),
(16, 16, 16, 'https://upload.wikimedia.org/wikipedia/id/e/ed/The_Raid_Poster.JPG'),
(17, 17, 17, 'https://upload.wikimedia.org/wikipedia/id/4/4c/Miracle_in_Cell_No_7_poster.jpg'),
(18, 18, 18, 'https://upload.wikimedia.org/wikipedia/id/9/95/Train_to_Busan.jpg'),
(19, 19, 19, 'https://upload.wikimedia.org/wikipedia/id/e/e3/Secretly_Greatly_poster.jpg'),
(20, 20, 20, 'https://upload.wikimedia.org/wikipedia/id/b/be/Hachi_poster.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tb_genre`
--

CREATE TABLE `tb_genre` (
  `id_genre` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_genre',
  `genre` varchar(50) NOT NULL COMMENT 'genre pada setiap filmnya'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_genre`
--

INSERT INTO `tb_genre` (`id_genre`, `genre`) VALUES
(1, 'Action'),
(2, 'Adventure'),
(3, 'Comedy'),
(4, 'Crime'),
(5, 'Drama'),
(6, 'Fantasy'),
(7, 'Historical'),
(8, 'Horror'),
(9, 'Mystery'),
(10, 'Romance'),
(11, 'Saga'),
(12, 'Science Fiction'),
(13, 'Thriller '),
(14, 'Western');

-- --------------------------------------------------------

--
-- Table structure for table `tb_keranjang`
--

CREATE TABLE `tb_keranjang` (
  `id_keranjang` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_keranjang',
  `id_cust` int(11) NOT NULL COMMENT 'menghubungkan data yang ada di tabel tb_custoomer'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_keranjang`
--

INSERT INTO `tb_keranjang` (`id_keranjang`, `id_cust`) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 4),
(6, 4),
(7, 5),
(8, 6),
(9, 7),
(10, 7),
(11, 8),
(12, 9),
(13, 9),
(14, 10),
(15, 10);

-- --------------------------------------------------------

--
-- Table structure for table `tb_movie`
--

CREATE TABLE `tb_movie` (
  `id_movie` int(11) NOT NULL COMMENT 'id primary key untuk tabel tb_movie',
  `id_genre` int(11) NOT NULL COMMENT 'menghubungkana data yang ada di tabel tb_genre',
  `judul` varchar(150) NOT NULL COMMENT 'judul pada setiap filmnya',
  `tahun_produksi` int(4) NOT NULL COMMENT 'tahun film tersebut tayang ',
  `durasi` int(11) NOT NULL COMMENT 'lama film tayang (dalam menit)',
  `rating_imdb` decimal(10,1) NOT NULL COMMENT 'rating yang diambil dari imdb',
  `rated` varchar(10) NOT NULL COMMENT 'menunjukan film tersebut layak ditonton untuk kalangan usia berapa saja',
  `bahasa` varchar(50) NOT NULL COMMENT 'bahasa yang digunakan di film',
  `subtitle` varchar(50) NOT NULL COMMENT 'subtitle yang tersedia dalam bahasa apa saja'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_movie`
--

INSERT INTO `tb_movie` (`id_movie`, `id_genre`, `judul`, `tahun_produksi`, `durasi`, `rating_imdb`, `rated`, `bahasa`, `subtitle`) VALUES
(1, 1, 'Thor: Ragnarok', 2017, 130, '7.9', 'PG-13', 'English', 'Indonesia'),
(2, 1, 'Wonder Woman', 2017, 141, '7.5', 'PG-13', 'English', 'Indonesia'),
(3, 3, 'Coco', 2017, 105, '8.5', 'PG', 'English', 'Indonesia'),
(4, 7, 'The Post', 2017, 116, '7.2', 'PG-13', 'English', 'Indonesia'),
(5, 10, 'Beauty and the Beast', 2017, 129, '7.2', 'PG', 'English', 'Indonesia'),
(6, 8, 'It', 2017, 135, '7.5', 'R', 'English', 'English'),
(7, 2, 'The Lord of the Rings: The Two Towers', 2002, 179, '8.7', 'PG-13', 'English', 'English'),
(8, 4, 'The Dark Knight', 2008, 152, '9.0', 'PG-13', 'English', 'Indonesia'),
(9, 4, 'Catch Me If You Can', 2002, 141, '8.1', 'PG-13', 'English', 'English'),
(10, 6, 'Star Wars: Episode IV - A New Hope', 1977, 121, '8.6', 'PG-13', 'English', 'Indonesia'),
(11, 1, 'Inception', 2010, 148, '8.8', 'PG-13', 'English', 'Indonesia'),
(12, 10, 'Titanic', 1997, 194, '7.8', 'PG-13', 'English', 'Indonesia'),
(13, 2, 'Finding Nemo', 2003, 100, '8.1', 'G', 'English ', 'Indonesia'),
(14, 5, 'Laskar Pelangi', 2008, 124, '7.8', 'PG-13', 'Indonesia', ''),
(15, 5, 'Habibie & Ainun', 2012, 120, '7.6', 'PG-13', 'Indonesia', ''),
(16, 1, 'The Raid: Redemption', 2011, 101, '7.6', 'R', 'Indonesia', 'English'),
(17, 5, 'Miracle in Cell No. 7', 2013, 127, '8.2', 'PG-13', 'Korea', 'Indonesia'),
(18, 13, 'Train to Busan', 2016, 118, '7.5', 'PG-13', 'Korea', 'English'),
(19, 5, 'Secretly, Greatly', 2013, 124, '6.9', 'R', 'Korea', 'English'),
(20, 5, 'Hachi: A Dog\'s Tale', 2009, 99, '8.1', 'G', 'Japan', 'English');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_customer`
--
ALTER TABLE `tb_customer`
  ADD PRIMARY KEY (`id_cust`);

--
-- Indexes for table `tb_detail_keranjang`
--
ALTER TABLE `tb_detail_keranjang`
  ADD PRIMARY KEY (`id_detail`),
  ADD KEY `id_keranjang` (`id_keranjang`),
  ADD KEY `id_dvd` (`id_dvd`);

--
-- Indexes for table `tb_dvd`
--
ALTER TABLE `tb_dvd`
  ADD PRIMARY KEY (`id_dvd`),
  ADD KEY `id_movie` (`id_movie`);

--
-- Indexes for table `tb_gambar_dvd`
--
ALTER TABLE `tb_gambar_dvd`
  ADD PRIMARY KEY (`id_gambar`);

--
-- Indexes for table `tb_genre`
--
ALTER TABLE `tb_genre`
  ADD PRIMARY KEY (`id_genre`);

--
-- Indexes for table `tb_keranjang`
--
ALTER TABLE `tb_keranjang`
  ADD PRIMARY KEY (`id_keranjang`),
  ADD KEY `id_cust` (`id_cust`);

--
-- Indexes for table `tb_movie`
--
ALTER TABLE `tb_movie`
  ADD PRIMARY KEY (`id_movie`),
  ADD KEY `id_genre` (`id_genre`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_customer`
--
ALTER TABLE `tb_customer`
  MODIFY `id_cust` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_customer', AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tb_detail_keranjang`
--
ALTER TABLE `tb_detail_keranjang`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_detail_keranjang', AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tb_dvd`
--
ALTER TABLE `tb_dvd`
  MODIFY `id_dvd` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_dvd', AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tb_gambar_dvd`
--
ALTER TABLE `tb_gambar_dvd`
  MODIFY `id_gambar` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_gambar_dvd', AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tb_genre`
--
ALTER TABLE `tb_genre`
  MODIFY `id_genre` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_genre', AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tb_keranjang`
--
ALTER TABLE `tb_keranjang`
  MODIFY `id_keranjang` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_keranjang', AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tb_movie`
--
ALTER TABLE `tb_movie`
  MODIFY `id_movie` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_movie', AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_detail_keranjang`
--
ALTER TABLE `tb_detail_keranjang`
  ADD CONSTRAINT `tb_detail_keranjang_ibfk_1` FOREIGN KEY (`id_keranjang`) REFERENCES `tb_keranjang` (`id_keranjang`),
  ADD CONSTRAINT `tb_detail_keranjang_ibfk_2` FOREIGN KEY (`id_dvd`) REFERENCES `tb_dvd` (`id_dvd`);

--
-- Constraints for table `tb_dvd`
--
ALTER TABLE `tb_dvd`
  ADD CONSTRAINT `tb_dvd_ibfk_1` FOREIGN KEY (`id_movie`) REFERENCES `tb_movie` (`id_movie`);

--
-- Constraints for table `tb_keranjang`
--
ALTER TABLE `tb_keranjang`
  ADD CONSTRAINT `tb_keranjang_ibfk_1` FOREIGN KEY (`id_cust`) REFERENCES `tb_customer` (`id_cust`);

--
-- Constraints for table `tb_movie`
--
ALTER TABLE `tb_movie`
  ADD CONSTRAINT `tb_movie_ibfk_1` FOREIGN KEY (`id_genre`) REFERENCES `tb_genre` (`id_genre`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
