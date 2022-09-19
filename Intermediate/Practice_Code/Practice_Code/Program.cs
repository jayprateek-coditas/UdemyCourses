

using Practice_Code.Codes;

var dbMigrator =new DbMigrator(new logger());


dbMigrator.Migrate();

var installer =new Installer(new logger());

installer.Install();

