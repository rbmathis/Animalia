namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys;

/// <summary>
/// Species: Cryptomys sp. Sekute
/// NCBI TaxId: 260989
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cryptomys_sp_Sekute : Cryptomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cryptomys sp. Sekute";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cryptomys_sp_Sekute";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260989;
}
