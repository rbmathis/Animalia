namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus;

/// <summary>
/// Species: Plecotus sp. V3
/// NCBI TaxId: 479724
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plecotus_sp_V3 : Plecotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plecotus sp. V3";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plecotus_sp_V3";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 479724;
}
