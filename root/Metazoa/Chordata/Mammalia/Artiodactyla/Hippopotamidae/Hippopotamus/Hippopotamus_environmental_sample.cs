namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hippopotamus;

/// <summary>
/// Species: Hippopotamus environmental sample
/// NCBI TaxId: 2665951
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippopotamus_environmental_sample : Hippopotamus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippopotamus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippopotamus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2665951;
}
