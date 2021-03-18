-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 12, 2018 at 04:54 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `msm`
--
CREATE DATABASE IF NOT EXISTS `msm` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `msm`;

-- --------------------------------------------------------

--
-- Table structure for table `add_courses`
--

CREATE TABLE IF NOT EXISTS `add_courses` (
  `course_code` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `hours` int(11) NOT NULL,
  `ECTS` int(11) NOT NULL,
  PRIMARY KEY (`course_code`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `add_courses`
--

INSERT INTO `add_courses` (`course_code`, `name`, `type`, `hours`, `ECTS`) VALUES
(1, 'Accounting for managers', 'MBA', 20, 24),
(2, 'Managerial economics', 'CBA', 24, 24);

-- --------------------------------------------------------

--
-- Table structure for table `grade`
--

CREATE TABLE IF NOT EXISTS `grade` (
  `grade_code` decimal(18,0) NOT NULL,
  `Unique_num` varchar(50) NOT NULL,
  `course_code` int(11) NOT NULL,
  `intake_code` int(11) NOT NULL,
  `Assignment` decimal(18,0) NOT NULL,
  `final_Exam` decimal(18,0) NOT NULL,
  `Total_grade` decimal(18,0) NOT NULL,
  `Total_grade_Resit` decimal(18,0) DEFAULT NULL,
  `year` date NOT NULL,
  `sync_grade` int(11) NOT NULL,
  PRIMARY KEY (`grade_code`),
  KEY `grade_fk` (`course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grade`
--

INSERT INTO `grade` (`grade_code`, `Unique_num`, `course_code`, `intake_code`, `Assignment`, `final_Exam`, `Total_grade`, `Total_grade_Resit`, `year`, `sync_grade`) VALUES
('0', '32/E-MBA/18', 1, 12, '20', '40', '60', NULL, '0000-00-00', 0),
('31', '31/E-MBA/18', 1, 12, '58', '98', '198', '67', '2018-08-07', 0),
('32', '32/E-MBA/18', 2, 12, '30', '60', '90', '100', '2018-08-01', 0),
('35', '32/E-MBA/18', 1, 12, '40', '40', '80', NULL, '2018-08-01', 12);

-- --------------------------------------------------------

--
-- Table structure for table `grievance_cba`
--

CREATE TABLE IF NOT EXISTS `grievance_cba` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Unqiue_num` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `student_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Intake_code` int(11) DEFAULT NULL,
  `what_BeingGrieved` text COLLATE utf8_unicode_ci,
  `date_occurrence` date DEFAULT NULL,
  `explanation_grieved` text COLLATE utf8_unicode_ci,
  `reason_grieved` text COLLATE utf8_unicode_ci,
  `date_filing` date DEFAULT NULL,
  `sync_grievance_cba` int(11) NOT NULL,
  `accepted` char(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `code_1` (`Unqiue_num`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `grievance_cba`
--

INSERT INTO `grievance_cba` (`ID`, `Unqiue_num`, `student_name`, `Intake_code`, `what_BeingGrieved`, `date_occurrence`, `explanation_grieved`, `reason_grieved`, `date_filing`, `sync_grievance_cba`, `accepted`) VALUES
(1, '2147483647', 'marwa khalid almqtary', 2, 'uyduiykrga,kkjdhuq', '2018-07-05', 'ygtqdlhedydh', 'YTFGDGUKJ', '2018-07-10', 0, NULL),
(2, '45/E-MBA/18', 'ertyuiiu khalid al', 2, 'HAGHBS', '2018-07-12', 'HFAHBSH', 'BDSYHJHUY', '2018-07-12', 0, NULL),
(3, '15/E-MBA/18', 'alaa abdalhamid as', 1, 'jadsduiya', '2018-08-09', 'heahhhye', 'my degree is wrong', '2018-08-20', 0, NULL),
(4, '36/E-MBA/18', 'ali hamid al', 8, 'COURSE OF MANEGERIAL', '2018-08-23', 'I have wrong result', 'correct my result', '2018-08-03', 0, NULL),
(5, '36/E-MBA/18', 'ali hamid al', 8, 'COURSE OF MANEGERIAL', '2018-08-23', 'I have wrong result', 'correct my result', '2018-08-03', 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `grievance_msm`
--

CREATE TABLE IF NOT EXISTS `grievance_msm` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `Unique_num` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Title` varchar(50) CHARACTER SET utf8 NOT NULL,
  `student_name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `program_type` char(10) CHARACTER SET utf8 NOT NULL,
  `Intake_code` int(11) NOT NULL,
  `Institution_name` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `program_location` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Course_name` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `lecturer_name` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Assign_or_Exam` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `ind_or_Grop` char(10) CHARACTER SET utf8 DEFAULT NULL,
  `grade_result` int(11) DEFAULT NULL,
  `Project_Title` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Supervisor` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Evaluator` text CHARACTER SET utf8,
  `Date` date DEFAULT NULL,
  `grade_project` int(11) DEFAULT NULL,
  `BHAP_title` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Coach` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Evaluator_BHAP` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `date_BHAP` date DEFAULT NULL,
  `Question` text CHARACTER SET utf8,
  `Objection` text CHARACTER SET utf8,
  `Motivation` text CHARACTER SET utf8,
  `Declaration_date` date DEFAULT NULL,
  `sync_grievance_msm` int(11) NOT NULL,
  `accepted` char(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`code`),
  KEY `Unique_num` (`Unique_num`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Dumping data for table `grievance_msm`
--

INSERT INTO `grievance_msm` (`code`, `Unique_num`, `Title`, `student_name`, `program_type`, `Intake_code`, `Institution_name`, `program_location`, `Course_name`, `lecturer_name`, `Assign_or_Exam`, `ind_or_Grop`, `grade_result`, `Project_Title`, `Supervisor`, `Evaluator`, `Date`, `grade_project`, `BHAP_title`, `Coach`, `Evaluator_BHAP`, `date_BHAP`, `Question`, `Objection`, `Motivation`, `Declaration_date`, `sync_grievance_msm`, `accepted`) VALUES
(1, '45/E-MBA/18', 'Mr', 'ertyuiiu khalid al', 'PhD', 6, 'ali', 'yemen', 'PHP', 'NAJY', 'assign', 'Individual', 56, '', '', '', '0000-00-00', 0, '', '', '', '0000-00-00', '', '', '', '2018-07-04', 0, NULL),
(2, '15/E-MBA/18', 'Mr', 'alaa abdalhamid as', 'DBA', 6, 'ali', 'yemen', '', '', '', '', 0, '', '', '', '0000-00-00', 0, '', '', '', '0000-00-00', '', '', '', '0000-00-00', 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `intake`
--

CREATE TABLE IF NOT EXISTS `intake` (
  `intake_code` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `num_intake` int(11) NOT NULL,
  `year` int(11) NOT NULL,
  PRIMARY KEY (`intake_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `registered_student`
--

CREATE TABLE IF NOT EXISTS `registered_student` (
  `Unique_num` varchar(50) NOT NULL,
  `TOEFL` varchar(50) DEFAULT NULL,
  `Specialization` varchar(50) DEFAULT NULL,
  `Worked_Fulltime` varchar(50) DEFAULT NULL,
  `document_path` varchar(50) DEFAULT NULL,
  `student_id` varchar(50) NOT NULL,
  `state_id` int(11) DEFAULT NULL,
  `Intake_code` int(11) NOT NULL,
  `accepted` char(10) DEFAULT NULL,
  `sync_registeredStudent` int(11) NOT NULL,
  PRIMARY KEY (`Unique_num`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `request_course`
--

CREATE TABLE IF NOT EXISTS `request_course` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `Unique_num` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `student_name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Intake_code` int(11) NOT NULL,
  `course_name` varchar(50) CHARACTER SET utf8 NOT NULL,
  `segment_taken` varchar(50) CHARACTER SET utf8 NOT NULL,
  `data` date NOT NULL,
  `originally_taken` varchar(50) CHARACTER SET utf8 NOT NULL,
  `retake_intake` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Reason` text CHARACTER SET utf8 NOT NULL,
  `sync_request_course` int(11) NOT NULL,
  `accepted` char(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=7 ;

--
-- Dumping data for table `request_course`
--

INSERT INTO `request_course` (`code`, `Unique_num`, `student_name`, `Intake_code`, `course_name`, `segment_taken`, `data`, `originally_taken`, `retake_intake`, `Reason`, `sync_request_course`, `accepted`) VALUES
(1, '45/E-MBA/18', 'ertyuiiu khalid al', 4, 'php', 'FDS', '2018-07-05', '2018-07-06', 'EWAD', 'jdahsbhukwja', 0, ''),
(2, '15/E-MBA/18', 'alaa abdalhamid as', 1, 'c#', 'FDS', '2018-08-22', '2018-08-08', 'EWAD', 'jejshdueuwuehjj', 0, ''),
(3, '15/E-MBA/18', 'alaa abdalhamid as', 1, 'c#', 'FDS', '2018-08-22', '2018-08-08', 'EWAD', 'jejshdueuwuehjj', 0, ''),
(4, '28/E-MBA/18', 'ENTESAR hamid almqtary', 1, 'c++', 'FFF', '2018-08-05', '2018-08-09', '2', 'illness', 0, ''),
(5, '28/E-MBA/18', 'ENTESAR hamid almqtary', 1, 'it managmet', '3', '2018-08-05', '2018-08-09', '2', '', 0, ''),
(6, '28/E-MBA/18', 'ENTESAR hamid almqtary', 1, 'php', 'jjkk', '2018-08-14', '2018-08-09', '3', 'ILNESS', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `request_exam`
--

CREATE TABLE IF NOT EXISTS `request_exam` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `Unique_num` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `student_name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Intake_code` int(11) NOT NULL,
  `course_name` varchar(50) CHARACTER SET utf8 NOT NULL,
  `assignment` char(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `final_exam` char(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `reason_request` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `other_reson` text CHARACTER SET utf8,
  `previously_exam` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `name_course` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `date` date DEFAULT NULL,
  `sync_request_exam` int(11) NOT NULL,
  `accepted` char(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`code`),
  KEY `student_name` (`student_name`),
  KEY `code` (`code`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `request_exam`
--

INSERT INTO `request_exam` (`code`, `Unique_num`, `student_name`, `Intake_code`, `course_name`, `assignment`, `final_exam`, `reason_request`, `other_reson`, `previously_exam`, `name_course`, `date`, `sync_request_exam`, `accepted`) VALUES
(1, '123', 'marwa', 4, 'nnnnnnnn', 'Assignment', NULL, 'illness(medical documentation required including p', NULL, 'no', NULL, '2018-07-03', 0, NULL),
(2, '15/E-MBA/18', 'alaa abdalhamid as', 1, 'php', NULL, 'Exam', 'illness(medical documentation required including p', NULL, 'no', NULL, '2018-08-28', 0, NULL),
(3, '15/E-MBA/18', 'alaa abdalhamid as', 1, 'php', NULL, 'Exam', 'illness(medical documentation required including p', NULL, 'no', NULL, '2018-08-28', 0, NULL),
(4, '28/E-MBA/18', 'ENTESAR hamid almqtary', 1, 'php', 'Assignment', NULL, ' Traveling(visa/passport documentation required)', NULL, 'no', NULL, '2018-08-27', 0, NULL),
(5, '36/E-MBA/18', 'ali hamid al', 8, 'it managmet', NULL, 'Exam', 'illness(medical documentation required including p', NULL, 'yes', '', '2018-08-03', 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE IF NOT EXISTS `student` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `M_F` char(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `counterpart` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `first_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `middle_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `family_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `home_address` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `city` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `postal_code` int(11) DEFAULT NULL,
  `country` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `home_telephone` int(11) DEFAULT NULL,
  `home_fax` int(11) DEFAULT NULL,
  `mobile_phone` int(11) DEFAULT NULL,
  `personal_email` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `date_birth` date DEFAULT NULL,
  `place_birth` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nationality` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `preferred_address` char(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_id` int(11) DEFAULT NULL,
  `data_passport_num` int(11) DEFAULT NULL,
  `data_issue_place` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_date_issue` date DEFAULT NULL,
  `data_date_expiration` date DEFAULT NULL,
  `emergency_person` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `emergency_type_relation` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `emergency_address` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `emergency_city` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `emergency_code` int(11) DEFAULT NULL,
  `emergency_country` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `emergency_telephone` int(11) DEFAULT NULL,
  `emergency_fax` int(11) DEFAULT NULL,
  `emergency_mobile` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `emergency_email` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_highest` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_highest_other` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_list_academic` text COLLATE utf8_unicode_ci,
  `educational_institute1` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_start_date1` date DEFAULT NULL,
  `educational_finish_date1` date DEFAULT NULL,
  `educational_degree1` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_majer1` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_institute2` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_start_date2` date DEFAULT NULL,
  `educational_finish_date2` date DEFAULT NULL,
  `educational_degree2` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_majer2` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_institute3` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_start_date3` date DEFAULT NULL,
  `educational_finish_date3` date DEFAULT NULL,
  `educational_degree3` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `educational_majer3` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_name_org` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_type_org` char(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_business_add` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_country` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_city` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_code` int(11) DEFAULT NULL,
  `professional_telephone` int(11) DEFAULT NULL,
  `professional_fax` int(11) DEFAULT NULL,
  `professional_mobile` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `professional_email` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_current_position` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_position_since` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_description` text COLLATE utf8_unicode_ci,
  `professional_name_org1` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_position_held1` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_start_date1` date DEFAULT NULL,
  `professional_finish_date1` date DEFAULT NULL,
  `professional_description1` text COLLATE utf8_unicode_ci,
  `professional_name_org2` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_position_held2` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `professional_start_date2` date DEFAULT NULL,
  `professional_finish_date2` date DEFAULT NULL,
  `professional_description2` text COLLATE utf8_unicode_ci,
  `Professional_Society_memberships` text CHARACTER SET utf8,
  `recommend_name` text COLLATE utf8_unicode_ci,
  `areas_account` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_law` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_ethics` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_economic` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_finance` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_IB` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_MIS` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_market` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_math` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_operation` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_org_behavior` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_research_skill` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_statistic` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_strategy` char(50) CHARACTER SET utf8 DEFAULT NULL,
  `areas_GMAT` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `areas_GMAT_yes_date` date DEFAULT NULL,
  `areas_GMAT_score` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `proficiency_oral` char(10) CHARACTER SET utf8 DEFAULT NULL,
  `proficiency_written` char(10) CHARACTER SET utf8 DEFAULT NULL,
  `proficiency_english_lang` char(10) CHARACTER SET utf8 DEFAULT NULL,
  `proficiency_lang_yes_date` date DEFAULT NULL,
  `proficiency_lang_yes_score` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `proficiency_lang_other` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `proficiency_result` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `profes_obj_learning` text COLLATE utf8_unicode_ci,
  `profes_obj_expectation` text COLLATE utf8_unicode_ci,
  `profes_obj_AC` text COLLATE utf8_unicode_ci,
  `other_program` text COLLATE utf8_unicode_ci,
  `other_about_program` char(20) CHARACTER SET utf8 DEFAULT NULL,
  `other_about_PA` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `other_about_other` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Statement_date` date DEFAULT NULL,
  `sync_student` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=37 ;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`ID`, `student_id`, `M_F`, `counterpart`, `Age`, `first_name`, `middle_name`, `family_name`, `home_address`, `city`, `postal_code`, `country`, `home_telephone`, `home_fax`, `mobile_phone`, `personal_email`, `date_birth`, `place_birth`, `nationality`, `preferred_address`, `data_id`, `data_passport_num`, `data_issue_place`, `data_date_issue`, `data_date_expiration`, `emergency_person`, `emergency_type_relation`, `emergency_address`, `emergency_city`, `emergency_code`, `emergency_country`, `emergency_telephone`, `emergency_fax`, `emergency_mobile`, `emergency_email`, `educational_highest`, `educational_highest_other`, `educational_list_academic`, `educational_institute1`, `educational_start_date1`, `educational_finish_date1`, `educational_degree1`, `educational_majer1`, `educational_institute2`, `educational_start_date2`, `educational_finish_date2`, `educational_degree2`, `educational_majer2`, `educational_institute3`, `educational_start_date3`, `educational_finish_date3`, `educational_degree3`, `educational_majer3`, `professional_name_org`, `professional_type_org`, `professional_business_add`, `professional_country`, `professional_city`, `professional_code`, `professional_telephone`, `professional_fax`, `professional_mobile`, `professional_email`, `professional_current_position`, `professional_position_since`, `professional_description`, `professional_name_org1`, `professional_position_held1`, `professional_start_date1`, `professional_finish_date1`, `professional_description1`, `professional_name_org2`, `professional_position_held2`, `professional_start_date2`, `professional_finish_date2`, `professional_description2`, `Professional_Society_memberships`, `recommend_name`, `areas_account`, `areas_law`, `areas_ethics`, `areas_economic`, `areas_finance`, `areas_IB`, `areas_MIS`, `areas_market`, `areas_math`, `areas_operation`, `areas_org_behavior`, `areas_research_skill`, `areas_statistic`, `areas_strategy`, `areas_GMAT`, `areas_GMAT_yes_date`, `areas_GMAT_score`, `proficiency_oral`, `proficiency_written`, `proficiency_english_lang`, `proficiency_lang_yes_date`, `proficiency_lang_yes_score`, `proficiency_lang_other`, `proficiency_result`, `profes_obj_learning`, `profes_obj_expectation`, `profes_obj_AC`, `other_program`, `other_about_program`, `other_about_PA`, `other_about_other`, `Statement_date`, `sync_student`) VALUES
(15, '15/E-MBA/18', 'MR', NULL, NULL, 'nada', 'mohammmed', 'aal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0),
(31, '31/E-MBA/18', 'Mrs', NULL, NULL, 'marwa', 'khalid', 'almqtary', 'sabeen', 'sanaa', 87, 'yemen', 7777777, 77, 967, 'marwa@gmail.com', '2018-08-01', 'yemen', 'yemeni', 'Business address', 87999, 7777777, 'hggh', '2018-08-08', '2018-08-03', 'mother', 'Father', 'sabeen', 'sanaa', 89, 'yemen', 999999999, 989386, '', 'a@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0),
(32, '32/E-MBA/18', 'Mrs', NULL, NULL, 'seham', 'hamid', 'moure', 'sabeen', 'sanaa', 78, 'yemen', 7777777, 111, 77777777, 'seham@gmail.com', '2018-08-01', 'sanaa', 'yemeni', 'Business address', 52, 7777777, 'uuuu', '2018-08-21', '2018-08-24', 'ahmed', 'Uncle', 'sabeen', 'sanaa', 890, 'yemen', 897, 2147483647, '', 'm@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0),
(33, '33/E-MBA/18', 'Ms', NULL, NULL, 'alaa', 'abdualameed', 'ashugaa', 'sabeen', 'sanaa', 88, 'اليمن', 500751, 98543, 967, 'alaa@gmail.com', '2018-08-28', 'yemen', 'yemeni', 'Business address', 52, 2147483647, 'sabeen', '2018-08-29', '2018-08-09', 'dad', 'Father', 'sabeen', 'sanaa', 88, 'yemen', 500751, 902, '', 'a@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0),
(34, '34/E-MBA/18', 'Mr', NULL, NULL, 'KHOLOOD', 'abu', 'rushod', 'sabeen', 'sanaa', 78, 'yemen', 7777777, 111, 967, 'KHOLOOD@gmail.com', '2018-08-09', 'sanaa', 'yemeni', 'Home address', 52, 2147483647, 'sabeen', '2018-08-01', '2018-08-02', 'hatem', 'Uncle', 'sabeen', 'sanaa', 998, 'hhh', 88, 2147483647, '', 'm@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0),
(35, '123', 'mf', NULL, NULL, 'admin', 'admi', 'admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0),
(36, '36/E-MBA/18', 'Mrs', NULL, NULL, 'ali', 'hamid', 'al', 'sabeen', 'sanaa', 68, 'yemen', 7777777, 6627777, 2147483647, 'ali@gmail.com', '2018-08-07', 'yemen', 'yemeni', 'Home address', 890, 7777777, 'sabeen', '2018-08-08', '2018-08-10', 'saleh', 'Brother', 'sabeen', 'sanaa', 890, 'yemen', 999999999, 988, '', 'mohammed@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ew', 'Fair /Exhibition', NULL, '', '2018-08-16', 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `userID` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(50) CHARACTER SET utf8 NOT NULL,
  `password` varchar(255) CHARACTER SET utf8 NOT NULL,
  `GroupID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`userID`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=36 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `email`, `password`, `GroupID`) VALUES
(32, 'seham@gmail.com', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 0),
(33, 'alaa@gmail.com', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 0),
(35, 'admin@gmail.com', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 1);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `grade`
--
ALTER TABLE `grade`
  ADD CONSTRAINT `grade_fk` FOREIGN KEY (`course_code`) REFERENCES `add_courses` (`course_code`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `code_1` FOREIGN KEY (`userID`) REFERENCES `student` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
