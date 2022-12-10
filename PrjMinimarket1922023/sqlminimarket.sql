/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.5.5-10.4.17-MariaDB : Database - minimarket
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`minimarket` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `minimarket`;

/*Table structure for table `admin` */

DROP TABLE IF EXISTS `admin`;

CREATE TABLE `admin` (
  `adminid` char(10) NOT NULL,
  `adminnamapass` varchar(100) DEFAULT NULL,
  `adminkaryawanid` char(10) DEFAULT NULL,
  `adminaktif` int(11) DEFAULT NULL,
  `adminlevel` int(11) DEFAULT NULL,
  PRIMARY KEY (`adminid`),
  KEY `adminkaryawanid` (`adminkaryawanid`),
  CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`adminkaryawanid`) REFERENCES `karyawan` (`karyawanid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `admin` */

insert  into `admin`(`adminid`,`adminnamapass`,`adminkaryawanid`,`adminaktif`,`adminlevel`) values ('imran','1d6408264d31d453d556c60fe7d0459e','k003',1,2),('karmen','59bcda7c438bad7d2afffe9e2fed00be','k004',1,2),('ranti','202cb962ac59075b964b07152d234b70','K001',1,1),('rendi','e56954b4f6347e897f954495eab16a88','K002',1,1);

/*Table structure for table `barang` */

DROP TABLE IF EXISTS `barang`;

CREATE TABLE `barang` (
  `barangid` char(10) NOT NULL,
  `barangbarcode` varchar(50) DEFAULT NULL,
  `barangnama` varchar(100) DEFAULT NULL,
  `barangsatuan` varchar(20) DEFAULT NULL,
  `barangkategoriid` int(11) DEFAULT NULL,
  `baranghargajual` double DEFAULT NULL,
  `barangstok` int(11) DEFAULT NULL,
  `barangtglinput` datetime DEFAULT NULL,
  `baranglastupdate` datetime DEFAULT NULL,
  `barangadminid` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`barangid`),
  KEY `barangadminid` (`barangadminid`),
  KEY `barangkategoriid` (`barangkategoriid`),
  CONSTRAINT `barang_ibfk_2` FOREIGN KEY (`barangadminid`) REFERENCES `admin` (`adminid`),
  CONSTRAINT `barang_ibfk_3` FOREIGN KEY (`barangkategoriid`) REFERENCES `kategori` (`kategoriid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `barang` */

insert  into `barang`(`barangid`,`barangbarcode`,`barangnama`,`barangsatuan`,`barangkategoriid`,`baranghargajual`,`barangstok`,`barangtglinput`,`baranglastupdate`,`barangadminid`) values ('A932','9385698','Apel','biji',6,6000,4,'2021-01-16 13:28:57','2021-01-16 13:28:57','ranti'),('e300','123456','celana panjang','pcs',3,100000,3,'2021-01-15 19:41:56','2021-01-15 19:41:56','ranti'),('H920','8562932','Nasi goreng','pcs',4,5000,2,'2021-01-16 13:25:52','2021-01-16 13:25:52','ranti'),('qqww','sssss','msnan','pcs',1,10000,2,'2021-01-15 15:04:35','2021-01-15 15:04:35','ranti'),('R049','3973296','tangga','pcs',5,50000,2,'2021-01-16 13:27:06','2021-01-16 13:27:06','ranti'),('w002','101010','bluss','pcs',2,50000,5,'2021-01-15 15:08:24','2021-01-15 15:08:24','ranti');

/*Table structure for table `beli` */

DROP TABLE IF EXISTS `beli`;

CREATE TABLE `beli` (
  `belinofak` char(15) NOT NULL,
  `belitgl` datetime DEFAULT NULL,
  `belipemasokid` char(7) DEFAULT NULL,
  `belidisc` int(11) DEFAULT NULL,
  `belitotalkotor` double DEFAULT NULL,
  `belitotalbersih` double DEFAULT NULL,
  `beliadminid` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`belinofak`),
  KEY `belipemasokid` (`belipemasokid`),
  KEY `beliadminid` (`beliadminid`),
  CONSTRAINT `beli_ibfk_1` FOREIGN KEY (`belipemasokid`) REFERENCES `pemasok` (`pemasokid`),
  CONSTRAINT `beli_ibfk_2` FOREIGN KEY (`beliadminid`) REFERENCES `admin` (`adminid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `beli` */

insert  into `beli`(`belinofak`,`belitgl`,`belipemasokid`,`belidisc`,`belitotalkotor`,`belitotalbersih`,`beliadminid`) values ('b500','2021-01-10 00:00:00','l245',0,0,0,'ranti'),('BC0001020','2021-01-16 00:00:00','l245',10000,0,90000,'ranti'),('FBL-16012021000','2021-01-16 00:00:00','m200',0,0,200000,'ranti'),('FBL-16012021210','2021-01-16 00:00:00','l245',20000,0,80000,'ranti'),('FBL-16012021212','2021-01-16 00:00:00','m200',5000,0,95000,'ranti'),('HI01478924','2021-01-16 00:00:00','m200',15000,0,85000,'ranti'),('HJ0276111','2021-01-15 00:00:00','l245',7000,0,63000,'ranti'),('HQ1028291','2021-01-16 00:00:00','l245',15000,0,85000,'ranti'),('ui097876','2021-01-16 00:00:00','m200',10000,0,190000,'ranti');

/*Table structure for table `detailbeli` */

DROP TABLE IF EXISTS `detailbeli`;

CREATE TABLE `detailbeli` (
  `dbeliid` bigint(20) NOT NULL AUTO_INCREMENT,
  `dbelinofak` char(15) DEFAULT NULL,
  `dbelibarangid` char(10) DEFAULT NULL,
  `dbeliqty` int(11) DEFAULT NULL,
  `dbeliharga` double DEFAULT NULL,
  PRIMARY KEY (`dbeliid`),
  KEY `detailbeli_ibfk_2` (`dbelibarangid`),
  CONSTRAINT `detailbeli_ibfk_1` FOREIGN KEY (`dbelibarangid`) REFERENCES `beli` (`belinofak`) ON UPDATE CASCADE,
  CONSTRAINT `detailbeli_ibfk_2` FOREIGN KEY (`dbelibarangid`) REFERENCES `barang` (`barangid`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `detailbeli` */

/*Table structure for table `detailjual` */

DROP TABLE IF EXISTS `detailjual`;

CREATE TABLE `detailjual` (
  `djualid` bigint(20) NOT NULL AUTO_INCREMENT,
  `djualjualnofak` varchar(15) DEFAULT NULL,
  `djualbarangid` char(10) DEFAULT NULL,
  `djualqty` int(11) DEFAULT NULL,
  `djualharga` double DEFAULT NULL,
  PRIMARY KEY (`djualid`),
  KEY `djualbarangid` (`djualbarangid`),
  KEY `djualjualnofak` (`djualjualnofak`),
  CONSTRAINT `detailjual_ibfk_1` FOREIGN KEY (`djualbarangid`) REFERENCES `barang` (`barangid`),
  CONSTRAINT `detailjual_ibfk_2` FOREIGN KEY (`djualjualnofak`) REFERENCES `jual` (`jualnofak`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `detailjual` */

/*Table structure for table `jual` */

DROP TABLE IF EXISTS `jual`;

CREATE TABLE `jual` (
  `jualnofak` char(15) NOT NULL,
  `jualtgl` datetime DEFAULT NULL,
  `jualdisc` int(11) DEFAULT NULL,
  `jualtotalkotor` double DEFAULT NULL,
  `jualtotalbersih` double DEFAULT NULL,
  `jualadminid` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`jualnofak`),
  KEY `jualadminid` (`jualadminid`),
  CONSTRAINT `jual_ibfk_1` FOREIGN KEY (`jualadminid`) REFERENCES `admin` (`adminid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `jual` */

insert  into `jual`(`jualnofak`,`jualtgl`,`jualdisc`,`jualtotalkotor`,`jualtotalbersih`,`jualadminid`) values ('FJL160120210001','2021-01-16 00:00:00',0,0,0,'ranti'),('t005','2021-01-16 00:00:00',0,0,0,'ranti');

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `karyawanid` char(10) NOT NULL,
  `karyawannama` varchar(50) DEFAULT NULL,
  `karyawanjkl` char(1) DEFAULT NULL,
  `karyawantmplhr` varchar(30) DEFAULT NULL,
  `karyawantgllhr` date DEFAULT NULL,
  `karyawannohp` varchar(16) DEFAULT NULL,
  `karyawanalamat` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`karyawanid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `karyawan` */

insert  into `karyawan`(`karyawanid`,`karyawannama`,`karyawanjkl`,`karyawantmplhr`,`karyawantgllhr`,`karyawannohp`,`karyawanalamat`) values ('K001','maranti','p','medan','2020-12-20','082239440781','batuaji'),('K002','Mawar','p','jakarta','2020-07-13','085288001245','bandung'),('k003','imran','L','kalimantan','2020-02-01','082203405879','kalimantan'),('k004','kistopel','L','tanjungpinang','2019-12-01','083567809700','batam');

/*Table structure for table `kategori` */

DROP TABLE IF EXISTS `kategori`;

CREATE TABLE `kategori` (
  `kategoriid` int(11) NOT NULL AUTO_INCREMENT,
  `kategorinama` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kategoriid`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `kategori` */

insert  into `kategori`(`kategoriid`,`kategorinama`) values (1,'sabun'),(2,'kosmetik'),(3,'pakaian'),(4,'makanan'),(5,'perabotan'),(6,'Buah');

/*Table structure for table `pemasok` */

DROP TABLE IF EXISTS `pemasok`;

CREATE TABLE `pemasok` (
  `pemasokid` char(7) NOT NULL,
  `pemasoknama` varchar(100) DEFAULT NULL,
  `pemasokalamat` varchar(200) DEFAULT NULL,
  `pemasoknotelp` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`pemasokid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `pemasok` */

insert  into `pemasok`(`pemasokid`,`pemasoknama`,`pemasokalamat`,`pemasoknotelp`) values ('l245','louis','092210305781','tarutung'),('m200','kevin','083320661020','nagoya'),('w201','andrian','094489021930','tanjung pinang');

/*Table structure for table `temp` */

DROP TABLE IF EXISTS `temp`;

CREATE TABLE `temp` (
  `id` char(10) NOT NULL,
  `qty` int(11) DEFAULT NULL,
  `harga` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `temp` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
