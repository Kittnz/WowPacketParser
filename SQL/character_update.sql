
CREATE TABLE IF NOT EXISTS `account` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT COMMENT 'Identifier',
  `username` varchar(32) NOT NULL,
  `gmlevel` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `sessionkey` longtext,
  `v` longtext,
  `s` longtext,
  `reg_mail` varchar(255) NOT NULL DEFAULT '',
  `token_key` varchar(100) NOT NULL DEFAULT '',
  `email` text,
  `joindate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `last_ip` varchar(30) NOT NULL DEFAULT '0.0.0.0',
  `last_attempt_ip` varchar(15) NOT NULL DEFAULT '127.0.0.1',
  `last_local_ip` varchar(30) NOT NULL DEFAULT '127.0.0.1',
  `failed_logins` int(11) unsigned NOT NULL DEFAULT '0',
  `locked` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `lock_country` varchar(2) NOT NULL DEFAULT '00',
  `last_login` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `last_pwd_reset` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `online` tinyint(4) NOT NULL DEFAULT '0',
  `expansion` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `mutetime` bigint(40) NOT NULL DEFAULT '0',
  `mutereason` varchar(255) NOT NULL DEFAULT '',
  `muteby` varchar(50) NOT NULL DEFAULT '',
  `locale` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `os` varchar(4) NOT NULL DEFAULT '',
  `recruiter` int(11) NOT NULL DEFAULT '0',
  `current_realm` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `banned` tinyint(1) unsigned NOT NULL DEFAULT '0',
  `mail_verif` tinyint(1) unsigned NOT NULL DEFAULT '0',
  `remember_token` varchar(100) NOT NULL DEFAULT '',
  `flags` int(10) unsigned NOT NULL DEFAULT '0',
  `security` varchar(255) DEFAULT NULL,
  `pass_verif` varchar(255) DEFAULT NULL COMMENT 'Web recover password',
  `email_verif` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Email verification',
  `email_check` varchar(255) DEFAULT NULL,
  `nostalrius_token` varchar(255) DEFAULT NULL,
  `nostalrius_token_enabled` tinyint(1) NOT NULL DEFAULT '0',
  `nostalrius_email` text,
  `nostalrius_reason` text,
  `geolock_pin` int(11) DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `idx_username` (`username`),
  KEY `idx_gmlevel` (`gmlevel`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='Account System';


DROP PROCEDURE IF EXISTS add_migration;
delimiter ??
CREATE PROCEDURE `add_migration`()
BEGIN
DECLARE v INT DEFAULT 1;
SET v = (SELECT COUNT(*) FROM `migrations` WHERE `id`='20210830151515');
IF v=0 THEN
INSERT INTO `migrations` VALUES ('20210830151515');
-- Add your query below.

ALTER TABLE `account`
    DROP COLUMN `last_attempt_ip`,
    DROP COLUMN `last_local_ip`,
    DROP COLUMN `last_pwd_reset`,
    DROP COLUMN `mutereason`,
    DROP COLUMN `muteby`,
    DROP COLUMN `recruiter`,
    DROP COLUMN `remember_token`,
    DROP COLUMN `reg_mail`,
    DROP COLUMN `banned`,
    DROP COLUMN `mail_verif`,
    DROP COLUMN `pass_verif`,
    DROP COLUMN `email_check`,
    DROP COLUMN `nostalrius_token`,
    DROP COLUMN `nostalrius_token_enabled`,
    DROP COLUMN `nostalrius_email`,
    DROP COLUMN `nostalrius_reason`;

-- End of migration.
END IF;
END??
delimiter ; 
CALL add_migration();
DROP PROCEDURE IF EXISTS add_migration;

ALTER TABLE `characters`
	ADD COLUMN `is_worldbot` TINYINT NOT NULL DEFAULT '1' AFTER `world_phase_mask`;
	
INSERT INTO `item_instance` (`guid`, `enchantments`) VALUES (0, '0');

ALTER TABLE `characters`
	ADD COLUMN `virtual_player_realm` INT NOT NULL AFTER `is_worldbot`;

CREATE TABLE `realm_template` (
	`virtual_realm_address` INT NOT NULL,
	`lookup_state` TINYINT NOT NULL,
	`is_local` TINYINT NOT NULL,
	`is_internal_realm` TINYINT NOT NULL,
	`realm_name_actual` VARCHAR(255) NOT NULL,
	`realm_name_normalized` VARCHAR(255) NOT NULL
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB;

ALTER TABLE `realm_template`
	ADD UNIQUE INDEX `Index 1` (`virtual_realm_address`);