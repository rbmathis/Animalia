namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys;

/// <summary>
/// Species: Cryptomys sp. Senanga
/// NCBI TaxId: 260990
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptomys_sp_Senanga : Cryptomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptomys sp. Senanga";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptomys_sp_Senanga";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260990;
}
