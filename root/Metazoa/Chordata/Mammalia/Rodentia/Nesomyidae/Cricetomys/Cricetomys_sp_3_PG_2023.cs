namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Cricetomys;

/// <summary>
/// Species: Cricetomys sp. 3 PG-2023
/// NCBI TaxId: 3064501
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cricetomys_sp_3_PG_2023 : Cricetomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cricetomys sp. 3 PG-2023";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cricetomys_sp_3_PG_2023";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3064501;
}
