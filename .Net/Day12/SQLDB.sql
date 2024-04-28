SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";
Create Schema Organization;
use Organization;
--
-- Database:  Organization 
--

-- --------------------------------------------------------

--
-- Table structure for table  Departments 
--

CREATE TABLE Departments (
   Id  int(11) NOT NULL,
   Name  varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table  Employees 
--

CREATE TABLE Employees(
  Id int(11) NOT NULL,
   Name  varchar(255) NOT NULL,
   Email  varchar(55) NOT NULL,
   Password  varchar(255) NOT NULL,
   Contact  varchar(15) NOT NULL,
   Address  varchar(255) NOT NULL,
   DepartmentId  int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table  Departments 
--
ALTER TABLE  Departments 
  ADD PRIMARY KEY ( Id );

--
-- Indexes for table  Employees 
--
ALTER TABLE  Employees 
  ADD PRIMARY KEY ( Id ),
  ADD KEY  DepartmentId  ( DepartmentId );

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table  Departments 
--
ALTER TABLE  Departments 
  MODIFY  Id  int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table  Employees 
--
ALTER TABLE  Employees 
  MODIFY  Id  int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table  Employees 
--
ALTER TABLE  Employees 
  ADD CONSTRAINT  Employees_ibfk_1  FOREIGN KEY ( DepartmentId ) REFERENCES  Departments  ( Id );
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;