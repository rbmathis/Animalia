namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Damaliscus;

/// <summary>
/// Species: Damaliscus lunatus
/// NCBI TaxId: 9929
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Damaliscus_lunatus : Damaliscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Damaliscus lunatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Damaliscus_lunatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9929;
}
