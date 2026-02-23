namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octodon;

/// <summary>
/// Species: Octodon pacificus
/// NCBI TaxId: 1897792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Octodon_pacificus : Octodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Octodon pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Octodon_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1897792;
}
