ALTER TABLE `characters`
	ADD COLUMN `is_worldbot` TINYINT NOT NULL DEFAULT '1' AFTER `world_phase_mask`;
	
INSERT INTO `item_instance` (`guid`, `enchantments`) VALUES (0, '0');

ALTER TABLE `characters`
	ADD COLUMN `virtual_player_realm` INT NULL AFTER `is_worldbot`;

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