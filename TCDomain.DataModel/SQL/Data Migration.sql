--Data Migration.sql
--   SQL Server TreasureChest Database Converion to the EntityFramweork Version...
--   Copyright © 2018 All Rights Reserved.
--*********************************************************************************************************************************
--
--	Modification History:
--	Date:       Developer:		Description:
--	02/01/19	Ken Clark		Created;
--=================================================================================================================================
--[myrdstest.cbbj4y6xmfye.us-east-1.rds.amazonaws.com,1433]
--[(localdb)\MSSQLLocalDB].[TC3EF6]
--=================================================================================================================================
Begin Try
	--[Locations] - Now done in Initial Seed process...
	--Print 'Locations';
	--INSERT INTO [dbo].[Locations] ([OID],
	--	[DateCreated],[DateModified],[Description],[Name],[PhysicalLocation])
	--SELECT ROW_NUMBER() OVER (Order by Location) AS ID, getdate(), getdate(), '', Location, ''
	--FROM (
	--	SELECT Distinct [Location] From [GGGSCP1].[TreasureChest].[dbo].[Locations]) myLocation
	--ORDER BY [Location];
	-----------------------------------------------------------
	exec sp_MigrateImages;
	exec sp_MigrateAircraftDesignations;
	exec sp_MigrateBlueAngelsHistory;
	exec sp_MigrateCompanies;
	exec sp_MigrateQueries;

	exec sp_MigrateShipClassTypes;
	exec sp_MigrateShipClasses;
	exec sp_MigrateShips;

	--exec sp_MigrateBooks;

	--exec sp_MigrateCollectables;

	--exec sp_MigrateKits;
	--exec sp_MigrateDecals;
	--exec sp_MigrateDetailSets;
	--exec sp_MigrateFinishingProducts;
	--exec sp_MigrateRockets;
	--exec sp_MigrateTools;
	--exec sp_MigrateTrains;

	--exec sp_MigrateMusic;
	--exec sp_MigrateSoftware;

	--exec sp_MigrateMovies;
	--exec sp_MigrateSpecials;
	--exec sp_MigrateVideoResearch;
	--exec sp_MigrateEpisodes;
----------------------------------------------------------------------------------------------------------------------
--[Books]
Print 'Books...';
INSERT INTO [dbo].[Books] ([OID],
	[AlphaSort],[Author],[MediaFormat],[ISBN],[Misc],[Subject],[Title],[Cataloged],[DateInventoried],
	[DatePurchased],[DateVerified],[Notes],[Price],[Value],[WishList],[DateCreated],[DateModified],[LocationID])
SELECT [Books].[ID],
	[Alphasort],[Author],[Format],[ISBN],[Misc],[Subject],[Title],[Cataloged],[DateInventoried],
	[DatePurchased],[DateVerified],[Notes],[Price],[Value],[WishList],[Books].[DateCreated],[Books].[DateModified],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Books] [Books]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Books].[Location]=[Locations].[OName]
ORDER BY [Books].[ID];
Print '   History';
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Books].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Books] [Books] On [History].[TableName]='Books' And [Books].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Books' 
ORDER BY [History].[ID];
Print '   Images';
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('BOOKS: '+[Books].[Title]),[Title]+' (Front Cover)','Books',getdate(),getdate(),Null,Null,[Image],[Books].[Title],Null,
	[newBooks].[ID],'Books',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Books] [Books]
	INNER JOIN [dbo].[Books] [newBooks] On [Books].[ID]=[newBooks].[OID]
WHERE [Books].[Image] is not Null
ORDER BY [Books].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('BOOKS: '+[Books].[Title]),[Title]+' (Back Cover)','Books',getdate(),getdate(),Null,Null,[OtherImage],[Books].[Title],Null,
	[newBooks].[ID],'Books',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Books] [Books]
	INNER JOIN [dbo].[Books] [newBooks] On [Books].[ID]=[newBooks].[OID]
WHERE [Books].[OtherImage] is not Null
ORDER BY [Books].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Collectables]
Print 'Collectables...';
INSERT INTO [dbo].[Collectables] ([OID],
	[Cataloged],[Condition],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],
	[Manufacturer],[Name],[Notes],[OutOfProduction],[Price],[Reference],[Series],[Type],[Value],[WishList],[LocationID])
SELECT [Collectables].[ID],
	1,[Condition],[Collectables].[DateCreated],[DateInventoried],[Collectables].[DateModified],[DatePurchased],[DateVerified],
	[Manufacturer],[Collectables].[Name],[Notes],[OutOfProduction],[Price],[Reference],[Series],[Type],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Collectables] [Collectables]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Collectables].[Location]=[Locations].[OName]
ORDER BY [Collectables].[ID];
Print '   History';
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Collectables].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Collectables] [Collectables] On [History].[TableName]='Collectables' And [Collectables].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Collectables' 
ORDER BY [History].[ID];
Print '   Images';
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Collectables: '+[Collectables].[Name]),[Collectables].[Name],'Collectables',getdate(),getdate(),Null,Null,[Image],[Collectables].[Name],Null,
	[newCollectables].[ID],'Collectables',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Collectables] [Collectables]
	INNER JOIN [dbo].[Collectables] [newCollectables] On [Collectables].[ID]=[newCollectables].[OID]
WHERE [Collectables].[Image] is not Null
ORDER BY [Collectables].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Collectables: '+[Collectables].[Name]),[Collectables].[Name],'Collectables',getdate(),getdate(),Null,Null,[OtherImage],[Collectables].[Name],Null,
	[newCollectables].[ID],'Collectables',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Collectables] [Collectables]
	INNER JOIN [dbo].[Collectables] [newCollectables] On [Collectables].[ID]=[newCollectables].[OID]
WHERE [Collectables].[OtherImage] is not Null
ORDER BY [Collectables].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Kits]
Print 'Kits'
INSERT INTO [dbo].[Kits] ([OID],
	[Cataloged],[Condition],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Decal_ID],
	[Designation],[DetailSet_ID],[Era],[Manufacturer],[Name],[Nation],[Notes],[OutOfProduction],[Price],[ProductCatalog],
	[Reference],[Scale],[Service],[Type],[Value],[WishList],[Location_ID])
SELECT [Kits].[ID],
	1,[Condition],[Kits].[DateCreated],[DateInventoried],[Kits].[DateModified],[DatePurchased],[DateVerified],Null,
	[Designation],Null,[Era],[Manufacturer],[Name],[Nation],[Notes],[OutOfProduction],[Price],[ProductCatalog],
	[Reference],[Scale],[Service],[Type],[Value],[WishList],[Locations].[ID]
--TODO: Resolve Linkage...
--[DecalID]
--[DetailSetID]
--[HasDecals]
--[HasDetailSet]
FROM [GGGSCP1].[TreasureChest].[dbo].[Kits] [Kits]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Kits].[Location]=[Locations].[OName]
ORDER BY [Kits].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Kits].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Kits] [Kits] On [History].[TableName]='Kits' And [Kits].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Kits' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Kits: '+[Kits].[Name]),Null,'Kits',getdate(),getdate(),Null,Null,[Image],[Kits].[Name],Null,
	[newKits].[ID],'Kits',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Kits] [Kits]
	INNER JOIN [dbo].[Kits] [newKits] On [Kits].[ID]=[newKits].[OID]
WHERE [Kits].[Image] is not Null
ORDER BY [Kits].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Kits: '+[Kits].[Name]),Null,'Kits',getdate(),getdate(),Null,Null,[OtherImage],[Kits].[Name],Null,
	[newKits].[ID],'Kits',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Kits] [Kits]
	INNER JOIN [dbo].[Kits] [newKits] On [Kits].[ID]=[newKits].[OID]
WHERE [Kits].[OtherImage] is not Null
ORDER BY [Kits].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Decals]
Print 'Decals';
INSERT INTO [dbo].[Decals] ([OID],
	[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Designation],
	[Manufacturer],[Name],[Nation],[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Location_ID])
SELECT [Decals].[ID],
	1,[Decals].[DateCreated],[DateInventoried],[Decals].[DateModified],[DatePurchased],[DateVerified],[Designation],
	[Manufacturer],[Decals].[Name],[Nation],[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Decals] [Decals]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Decals].[Location]=[Locations].[OName]
ORDER BY [Decals].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Decals].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Decals] [Decals] On [History].[TableName]='Decals' And [Decals].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Decals' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Decals: '+[Decals].[Name]),Null,'Decals',getdate(),getdate(),Null,Null,[Image],[Decals].[Name],Null,
	[newDecals].[ID],'Decals',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Decals] [Decals]
	INNER JOIN [dbo].[Decals] [newDecals] On [Decals].[ID]=[newDecals].[OID]
WHERE [Decals].[Image] is not Null
ORDER BY [Decals].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Decals: '+[Decals].[Name]),Null,'Decals',getdate(),getdate(),Null,Null,[OtherImage],[Decals].[Name],Null,
	[newDecals].[ID],'Decals',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Decals] [Decals]
	INNER JOIN [dbo].[Decals] [newDecals] On [Decals].[ID]=[newDecals].[OID]
WHERE [Decals].[OtherImage] is not Null
ORDER BY [Decals].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[DetailSets]
Print 'DetailSets';
INSERT INTO [dbo].[DetailSets] ([OID],
	[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Designation],
	[Manufacturer],[Name],[Nation],[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Location_ID])
SELECT [Detail Sets].[ID],
	1,[Detail Sets].[DateCreated],[DateInventoried],[Detail Sets].[DateModified],[DatePurchased],[DateVerified],[Designation],
	[Manufacturer],[Detail Sets].[Name],[Nation],[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Detail Sets] [Detail Sets]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Detail Sets].[Location]=[Locations].[OName]
ORDER BY [Detail Sets].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[DetailSets].[ID],'DetailSets',[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[DetailSets] [DetailSets] On [History].[TableName]='Detail Sets' And [DetailSets].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Detail Sets' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Detail Sets: '+[Detail Sets].[Name]),Null,'DetailSets',getdate(),getdate(),Null,Null,[Image],[Detail Sets].[Name],Null,
	[DetailSets].[ID],'DetailSets',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Detail Sets] [Detail Sets]
	INNER JOIN [dbo].[DetailSets] [DetailSets] On [Detail Sets].[ID]=[DetailSets].[OID]
WHERE [Detail Sets].[Image] is not Null
ORDER BY [Detail Sets].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Detail Sets: '+[Detail Sets].[Name]),Null,'DetailSets',getdate(),getdate(),Null,Null,[OtherImage],[Detail Sets].[Name],Null,
	[DetailSets].[ID],'DetailSets',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Detail Sets] [Detail Sets]
	INNER JOIN [dbo].[DetailSets] [DetailSets] On [Detail Sets].[ID]=[DetailSets].[OID]
WHERE [Detail Sets].[OtherImage] is not Null
ORDER BY [Detail Sets].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[FinishingProducts]
Print 'FinishingProducts'
INSERT INTO [dbo].[FinishingProducts] ([OID],
	[Cataloged],[Count],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Manufacturer],[Name],
	[Notes],[Price],[ProductCatalog],[Reference],[Type],[Value],[WishList],[Location_ID])
SELECT [ID],
	1,[Count],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Manufacturer],[Name],
	[Notes],[Price],[ProductCatalog],[Reference],[Type],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Finishing Products] [Finishing Products]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Finishing Products].[Location]=[Locations].[OName]
ORDER BY [Finishing Products].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[FinishingProducts].[ID],'Finishing Products',[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[FinishingProducts] [FinishingProducts] On [History].[TableName]='Finishing Products' And [FinishingProducts].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Finishing Products' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Finishing Products: '+[Finishing Products].[Name]),Null,'FinishingProducts',getdate(),getdate(),Null,Null,[Image],[Finishing Products].[Name],Null,
	[FinishingProducts].[ID],'FinishingProducts',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Finishing Products] [Finishing Products]
	INNER JOIN [dbo].[FinishingProducts] [FinishingProducts] On [Finishing Products].[ID]=[FinishingProducts].[OID]
WHERE [Finishing Products].[Image] is not Null
ORDER BY [Finishing Products].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Rockets]
Print 'Rockets'
INSERT INTO [dbo].[Rockets] ([OID],
	[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Designation],[Manufacturer],
	[Name],[Nation],[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Location_ID])
SELECT [ID],
	1,[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Designation],[Manufacturer],
	[Name],[Nation],[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Rockets] [Rockets]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Rockets].[Location]=[Locations].[OName]
ORDER BY [Rockets].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Rockets].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Rockets] [Rockets] On [History].[TableName]='Rockets' And [Rockets].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Rockets' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Rockets: '+[Rockets].[Name]),Null,'Rockets',getdate(),getdate(),Null,Null,[Image],[Rockets].[Name],Null,
	[newRockets].[ID],'Rockets',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Rockets] [Rockets]
	INNER JOIN [dbo].[Rockets] [newRockets] On [Rockets].[ID]=[newRockets].[OID]
WHERE [Rockets].[Image] is not Null
ORDER BY [Rockets].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Tools]
Print 'Tools'
INSERT INTO [dbo].[Tools] ([OID],
	[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Manufacturer],[Name],
	[Notes],[Price],[ProductCatalog],[Reference],[Value],[WishList],[Location_ID])
SELECT [ID],
	1,[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Manufacturer],[Name],
	[Notes],[Price],[ProductCatalog],[Reference],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Tools] [Tools]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Tools].[Location]=[Locations].[OName]
ORDER BY [Tools].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Tools].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Tools] [Tools] On [History].[TableName]='Tools' And [Tools].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Tools' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Tools: '+[Tools].[Name]),Null,'Tools',getdate(),getdate(),Null,Null,[Image],[Tools].[Name],Null,
	[newTools].[ID],'Tools',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Tools] [Tools]
	INNER JOIN [dbo].[Tools] [newTools] On [Tools].[ID]=[newTools].[OID]
WHERE [Tools].[Image] is not Null
ORDER BY [Tools].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Trains]
Print 'Trains'
INSERT INTO [dbo].[Trains] ([OID],
	[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Line],[Manufacturer],[Name],
	[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Location_ID])
SELECT [ID],
	1,[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[Line],[Manufacturer],[Line],
	[Notes],[Price],[ProductCatalog],[Reference],[Scale],[Type],[Value],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Trains] [Trains]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Trains].[Location]=[Locations].[OName]
ORDER BY [Trains].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Trains].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Trains] [Trains] On [History].[TableName]='Trains' And [Trains].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Trains' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
SELECT Null,Upper('Trains: '+[Trains].[Line]),Null,'Trains',getdate(),getdate(),Null,Null,[Image],[Trains].[Line],Null,
	[newTrains].[ID],'Trains',0,Null,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Trains] [Trains]
	INNER JOIN [dbo].[Trains] [newTrains] On [Trains].[ID]=[newTrains].[OID]
WHERE [Trains].[Image] is not Null
ORDER BY [Trains].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Music]
Print 'Music'
INSERT INTO [dbo].[Music] ([OID],
	[AlphaSort],[Artist],[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateVerified],[MediaFormat],
	[Notes],[Price],[Title],[Type],[Value],[WishList],[Year],[LocationID])
SELECT [Music].[ID],
	[AlphaSort],[Artist],[Inventoried],[Music].[DateCreated],[DateInventoried],[Music].[DateModified],[DatePurchased],[DateVerified],[Media],
	[Notes],[Price],[Title],[Type],[Value],[WishList],[Year],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Music] [Music]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Music].[Location]=[Locations].[OName]
ORDER BY [Music].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Music].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Music] [Music] On [History].[TableName]='Music' And [Music].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Music' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Music: '+[Music].[Title]),Null,'Music',getdate(),getdate(),Null,Null,[Image],[Music].[Title],Null,
	[newMusic].[ID],'Music',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Music] [Music]
	INNER JOIN [dbo].[Music] [newMusic] On [Music].[ID]=[newMusic].[OID]
WHERE [Music].[Image] is not Null
ORDER BY [Music].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Software]
Print 'Software'
INSERT INTO [dbo].[Software] ([OID],
	[AlphaSort],[Cataloged],[CDkey],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateReleased],[DateVerified],
	[Developer],[ISBN],[MediaFormat],[Notes],[Platform],[Price],[Publisher],[Title],[Type],[Value],[Version],[WishList],[LocationID])
SELECT [Software].[ID],
	[AlphaSort],[Cataloged],[CDkey],[Software].[DateCreated],[DateInventoried],[Software].[DateModified],[DatePurchased],[DateReleased],[DateVerified],
	[Developer],[ISBN],[Media],[Notes],[Platform],[Price],[Publisher],[Title],[Type],[Value],[Version],[WishList],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Software] [Software]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Software].[Location]=[Locations].[OName]
ORDER BY [Software].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Software].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Software] [Software] On [History].[TableName]='Software' And [Software].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Software' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Software: '+[Software].[Title]),Null,'Software',getdate(),getdate(),Null,Null,[Image],[Software].[Title],Null,
	[newSoftware].[ID],'Software',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Software] [Software]
	INNER JOIN [dbo].[Software] [newSoftware] On [Software].[ID]=[newSoftware].[OID]
WHERE [Software].[Image] is not Null
ORDER BY [Software].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Software: '+[Software].[Title]),Null,'Software',getdate(),getdate(),Null,Null,[OtherImage],[Software].[Title],Null,
	[newSoftware].[ID],'Software',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Software] [Software]
	INNER JOIN [dbo].[Software] [newSoftware] On [Software].[ID]=[newSoftware].[OID]
WHERE [Software].[OtherImage] is not Null
ORDER BY [Software].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Videos/Movies]
Print 'Videos/Movies'
INSERT INTO [dbo].[Videos] ([OID],
	[AlphaSort],[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateReleased],[DateVerified],
	[Distributor],[MediaFormat],[Notes],[Price],[Subject],[Title],[Value],[WishList],[StoreBought],[WMV],[LocationID])
SELECT [Movies].[ID],
	[Sort],1,[Movies].[DateCreated],[DateInventoried],[Movies].[DateModified],[DatePurchased],[ReleaseDate],[DateVerified],
	[Distributor],[Format],[Notes],[Price],[Subject],[Title],[Value],[WishList],[StoreBought],[WMV],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Movies] [Movies]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Movies].[Location]=[Locations].[OName]
ORDER BY [Movies].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Videos].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Videos] [Videos] On [History].[TableName]='Movies' And [Videos].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Movies' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Videos: '+[Movies].[Title]),[Movies].[Title],'Videos',getdate(),getdate(),Null,Null,[Image],[Movies].[Title],Null,
	[newVideos].[ID],'Videos',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Movies] [Movies]
	INNER JOIN [dbo].[Videos] [newVideos] On [Movies].[ID]=[newVideos].[OID]
WHERE [Movies].[Image] is not Null
ORDER BY [Movies].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Videos: '+[Movies].[Title]),[Movies].[Title],'Videos',getdate(),getdate(),Null,Null,[OtherImage],[Movies].[Title],Null,
	[newVideos].[ID],'Videos',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Movies] [Movies]
	INNER JOIN [dbo].[Videos] [newVideos] On [Movies].[ID]=[newMovies].[OID]
WHERE [Movies].[OtherImage] is not Null
ORDER BY [Movies].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Videos/Specials]
Print 'Videos/Specials'
INSERT INTO [dbo].[Videos] ([OID],
	[AlphaSort],[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateReleased],[DateVerified],
	[Distributor],[MediaFormat],[Notes],[Price],[Subject],[Title],[Value],[WishList],[StoreBought],[WMV],[LocationID])
SELECT [Specials].[ID],
	[Sort],1,[Specials].[DateCreated],[DateInventoried],[Specials].[DateModified],[DatePurchased],[ReleaseDate],[DateVerified],
	[Distributor],[Format],[Notes],[Price],[Subject],[Title],[Value],[WishList],[StoreBought],[WMV],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Specials] [Specials]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Specials].[Location]=[Locations].[OName]
ORDER BY [Specials].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Videos].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Videos] [Videos] On [History].[TableName]='Specials' And [Videos].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Specials' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Videos: '+[Specials].[Title]),[Specials].[Title],'Videos',getdate(),getdate(),Null,Null,[Image],[Specials].[Title],Null,
	[newSpecials].[ID],'Videos',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Specials] [Specials]
	INNER JOIN [dbo].[Specials] [newSpecials] On [Specials].[ID]=[newSpecials].[OID]
WHERE [Specials].[Image] is not Null
ORDER BY [Specials].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Videos: '+[Specials].[Title]),[Specials].[Title],'Videos',getdate(),getdate(),Null,Null,[OtherImage],[Specials].[Title],Null,
	[newSpecials].[ID],'Videos',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Specials] [Specials]
	INNER JOIN [dbo].[Specials] [newSpecials] On [Specials].[ID]=[newSpecials].[OID]
WHERE [Specials].[OtherImage] is not Null
ORDER BY [Specials].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Videos/Video Research]
Print 'Videos/Video Research'
INSERT INTO [dbo].[Videos] ([OID],
	[AlphaSort],[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateReleased],[DateVerified],
	[Distributor],[MediaFormat],[Notes],[Price],[Subject],[Title],[Value],[WishList],[StoreBought],[WMV],[LocationID])
SELECT [Video Research].[ID],
	[AlphaSort],1,[Video Research].[DateCreated],[DateInventoried],[Video Research].[DateModified],[DatePurchased],[ReleaseDate],[DateVerified],
	[Distributor],[Format],[Notes],[Price],[Subject],[Title],[Value],[WishList],0,[WMV],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Video Research] [Video Research]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Video Research].[Location]=[Locations].[OName]
ORDER BY [Video Research].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Videos].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [GGGSCP1].[TreasureChest].[dbo].[Video Research] [Video Research] On [History].[TableName]='Video Research' And [History].[RecordID]=[Video Research].[ID]
	INNER JOIN [dbo].[Videos] [Videos] On [Video Research].[ID]=[Videos].[OID]
		And [History].[RecordID]=[Video Research].[ID]


WHERE [History].[TableName]='Video Research' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Videos: '+[Video Research].[Title]),[Video Research].[Title],'Videos',getdate(),getdate(),Null,Null,[Image],[Specials].[Title],Null,
	[newSpecials].[ID],'Videos',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Video Research] [Video Research]
	INNER JOIN [dbo].[Video Research] [newVideo Research] On [Video Research].[ID]=[newVideo Research].[OID]
WHERE [Video Research].[Image] is not Null
ORDER BY [Video Research].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Videos: '+[Video Research].[Title]),[Video Research].[Title],'Videos',getdate(),getdate(),Null,Null,[OtherImage],[Video Research].[Title],Null,
	[newVideo Research].[ID],'Videos',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Video Research] [Video Research]
	INNER JOIN [dbo].[Video Research] [newVideo Research] On [Video Research].[ID]=[newVideo Research].[OID]
WHERE [Video Research].[OtherImage] is not Null
ORDER BY [Video Research].[ID];
GO
----------------------------------------------------------------------------------------------------------------------
--[Episodes]
Print 'Episodes';
INSERT INTO [dbo].[Episodes] ([OID],
	[Cataloged],[DateCreated],[DateInventoried],[DateModified],[DatePurchased],[DateReleased],[DateVerified],
	[Distributor],[MediaFormat],[Notes],[Number],[Price],[Series],[Subject],[Title],[Value],[WishList],[StoreBought],[Taped],[WMV],[LocationID])
SELECT [Episodes].[ID],
	1,[Episodes].[DateCreated],[DateInventoried],[Episodes].[DateModified],[DatePurchased],[ReleaseDate],[DateVerified],
	[Distributor],[Format],[Notes],[Number],[Price],[Series],[Subject],[Title],[Value],[WishList],[StoreBought],[Taped],[WMV],[Locations].[ID]
FROM [GGGSCP1].[TreasureChest].[dbo].[Episodes] [Episodes]
	LEFT OUTER JOIN [dbo].[Locations] [Locations] On [Episodes].[Location]=[Locations].[OName]
ORDER BY [Episodes].[ID];
INSERT INTO [dbo].[History] ([OID],
	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
SELECT [History].[ID],
	[History].[Column],[History].[DateChanged],getdate(),getdate(),[History].[OriginalValue],[Episodes].[ID],[History].[TableName],[History].[Value],[History].[Who]
FROM [GGGSCP1].[TreasureChest].[dbo].[History] [History]
	INNER JOIN [dbo].[Episodes] [Episodes] On [History].[TableName]='Episodes' And [Episodes].[OID]=[History].[RecordID]
WHERE [History].[TableName]='Episodes' 
ORDER BY [History].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Episodes: '+[Episodes].[Title]),[Episodes].[Title],'Episodes',getdate(),getdate(),Null,Null,[Image],[Episodes].[Title],Null,
	[newEpisodes].[ID],'Episodes',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Episodes] [Episodes]
	INNER JOIN [dbo].[Episodes] [newEpisodes] On [Episodes].[ID]=[newEpisodes].[OID]
WHERE [Episodes].[Image] is not Null
ORDER BY [Episodes].[ID];
INSERT INTO [dbo].[Images] ([OID],
	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],
	[RecordID],[TableName],[Thumbnail],[URL],[Width])
SELECT Null,Upper('Episodes: '+[Episodes].[Title]),[Episodes].[Title],'Episodes',getdate(),getdate(),Null,Null,[OtherImage],[Episodes].[Title],Null,
	[newEpisodes].[ID],'Episodes',0,Null,Null
FROM [GGGSCP1].[TreasureChest].[dbo].[Episodes] [Episodes]
	INNER JOIN [dbo].[Episodes] [newEpisodes] On [Episodes].[ID]=[newEpisodes].[OID]
WHERE [Episodes].[OtherImage] is not Null
ORDER BY [Episodes].[ID];
GO
----------------------------------------------------------------------------------------------------------------------

--Select '['+TABLE_NAME+']' From [INFORMATION_SCHEMA].[TABLES] Order By TABLE_NAME;
--Select '['+TABLE_NAME+']' From [INFORMATION_SCHEMA].[TABLES] Order By TABLE_NAME;
--Select '['+TABLE_NAME+']','['+COLUMN_NAME+']' From [INFORMATION_SCHEMA].[COLUMNS] Where TABLE_NAME In ('Class','Classification','Collectables','Companies','Decals','Detail Sets','Episodes','Finishing Products','History','Images','Kits','Locations','Movies','Music','Query','Rockets','Ships','Software','Specials','Tools','Trains','Video Research') And COLUMN_NAME Not In ('ID','RowID','Location_ID') Order By TABLE_NAME,COLUMN_NAME;
--Select '['+TABLE_NAME+']','['+COLUMN_NAME+']' From [INFORMATION_SCHEMA].[COLUMNS] Where TABLE_NAME In ('ShipClass','ShipClassificationTypes','Collectables','Companies','Decals','DetailSets','Episodes','FinishingProducts','History','Images','Kits','Locations','Movies','Music','Query','Rockets','Ships','Software','Specials','Tools','Trains','VideoResearch') And COLUMN_NAME Not In ('ID','RowID','Location_ID') Order By TABLE_NAME,COLUMN_NAME;

--TODO: Handle Location, Images and History...
--SELECT [ID]
--      ,[DateChanged]
--      ,[TableName]
--      ,[RecordID]
--      ,[Column]
--      ,[OriginalValue]
--      ,[Value],[Who]
--  FROM [dbo].[History]
--GO
--Select Location,Count(*) From Books Group By Location Order By Location;
--Select TableName,Count(*) From History Group By TableName Order By TableName;
--Select * From History Where TableName='Books';
--[History]
--INSERT INTO [dbo].[History] ([OID],
--	[Column],[DateChanged],[DateCreated],[DateModified],[OriginalValue],[RecordID],[TableName],[Value],[Who])
--SELECT [ID],
--	[Column],[DateChanged],[OriginalValue],[RecordID],[TableName],[Value],[Who])
--FROM [GGGSCP1].[TreasureChest].[dbo].[] ORDER BY [ID];
--GO
--[Images]
--INSERT INTO [dbo].[Images] ([OID],
--	[AlphaSort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],[RecordID],[TableName],
--	[Thumbnail],[ThumbnailImage_ID],[URL],[Width])
--SELECT [ID],
--	[Sort],[Caption],[Category],[DateCreated],[DateModified],[FileName],[Height],[Image],[Name],[Notes],[TableID],[TableName],
--	[Thumbnail],Null,[URL],[Width]
----Resolve Linkage...
----[ThumbnailImageID]
--FROM [GGGSCP1].[TreasureChest].[dbo].[Images] ORDER BY [ID];
--GO
End Try
Begin Catch
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;

    SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

	Print @ErrorMessage
	Insert Into ERROR_LOG(WHO,WHEN_DONE,WHY,OP_NUMBER,TX_NUMBER,TX_CODE,WHAT,WHATS_MORE,SESSION_ID,TASK_NUMBER) Values ('SUNGARD',CURRENT_TIMESTAMP,4,1,@TX_NUMBER,-1,@ErrorMessage,@ErrorMessage,0,0)

    --Use RAISERROR inside the CATCH block to return error information about the original error that caused execution to jump to the CATCH block.
    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
End Catch;
Go
