namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus;

/// <summary>
/// Species: Plecotus macrobullaris
/// NCBI TaxId: 242915
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plecotus_macrobullaris : Plecotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plecotus macrobullaris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plecotus_macrobullaris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 242915;
}
