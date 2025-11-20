
using System.ComponentModel;

battleHandler battleHandler = new battleHandler();
Warrior warrior = new Warrior("Berna");
Shop shop = new Shop();
DungeonHandler dungeonHandler = new DungeonHandler();

warrior.inventory.addItem(new ManaPotion(), 2);


dungeonHandler.doDungeonAdventure(5, Dungeon.DungeonType.Cave, warrior);


warrior.giveGold(1000);




