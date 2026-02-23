namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octodon;

/// <summary>
/// Species: Octodon sp. Andean
/// NCBI TaxId: 2819243
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Octodon_sp_Andean : Octodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Octodon sp. Andean";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Octodon_sp_Andean";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2819243;
}
