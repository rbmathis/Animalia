namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus arcticus
/// NCBI TaxId: 62618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_arcticus : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus arcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_arcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62618;
}
