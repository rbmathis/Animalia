namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys;

/// <summary>
/// Species: Cryptomys sp. Livingstone
/// NCBI TaxId: 260991
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptomys_sp_Livingstone : Cryptomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptomys sp. Livingstone";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptomys_sp_Livingstone";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260991;
}
