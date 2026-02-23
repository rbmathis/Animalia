namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octodon;

/// <summary>
/// Species: Octodon degus
/// NCBI TaxId: 10160
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Octodon_degus : Octodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Octodon degus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Octodon_degus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10160;
}
