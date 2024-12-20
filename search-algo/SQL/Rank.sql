

-- some test code

select Top 100 ProductId, Name, ListPrices,
RANK() OVER(Order by ListPrices desc) as RankByPrice
From Production.Product as p
Order by RankByPrice

-- some extra

select Top 100 ProductId, Name, ListPrices,
RANK() OVER(Order by ListPrices desc) as RankByPrice
From Production.Product as p
Order by RankByPrice