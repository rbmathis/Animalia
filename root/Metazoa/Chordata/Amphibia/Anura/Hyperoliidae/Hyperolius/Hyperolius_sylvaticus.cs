namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

/// <summary>
/// Species: Hyperolius sylvaticus
/// NCBI TaxId: 643498
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyperolius_sylvaticus : Hyperolius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyperolius sylvaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyperolius_sylvaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643498;
}
