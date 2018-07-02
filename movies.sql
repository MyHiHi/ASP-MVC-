/*
Navicat MySQL Data Transfer

Source Server         : 22
Source Server Version : 40122
Source Host           : localhost:3306
Source Database       : movies

Target Server Type    : MYSQL
Target Server Version : 40122
File Encoding         : 65001

Date: 2018-06-24 16:38:22
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `movie`
-- ----------------------------
DROP TABLE IF EXISTS `movie`;
CREATE TABLE `movie` (
  `id` int(11) NOT NULL auto_increment,
  `type` varchar(20) NOT NULL default '',
  `name` varchar(20) NOT NULL default '',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of movie
-- ----------------------------
INSERT INTO `movie` VALUES ('8', '科幻', '我问问');
INSERT INTO `movie` VALUES ('11', '恐怖', '全球复苏的');
INSERT INTO `movie` VALUES ('14', '战争', '和规范化');

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL auto_increment,
  `userName` varchar(20) NOT NULL default '',
  `userPassword` varchar(100) NOT NULL default '',
  `userEmail` varchar(50) NOT NULL default '',
  `userPhone` varchar(50) NOT NULL default '',
  `userBirth` datetime NOT NULL default '0000-00-00 00:00:00',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '11', '11', '123@qq.com', '1232545', '2018-06-27 14:12:00');
INSERT INTO `user` VALUES ('2', '小华1', '25f9e794323b453885f5181f1b624d0b', '4324@qq.com', '12345678945', '1996-03-28 00:00:00');
INSERT INTO `user` VALUES ('3', '峰峰2', '25f9e794323b453885f5181f1b624d0b', '4324@qq.com', '12345678945', '1996-03-18 00:00:00');
INSERT INTO `user` VALUES ('4', '14234', 'e10adc3949ba59abbe56e057f20f883e', '4324@qq.com', '12345678945', '1996-03-22 00:00:00');
INSERT INTO `user` VALUES ('5', 'root', '25f9e794323b453885f5181f1b624d0b', '4324@qq.com', '12345678945', '1996-03-28 00:00:00');
