namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hippopotamus;

/// <summary>
/// Species: Hippopotamus minor
/// NCBI TaxId: 2841798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippopotamus_minor : Hippopotamus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippopotamus minor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippopotamus_minor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2841798;
}
