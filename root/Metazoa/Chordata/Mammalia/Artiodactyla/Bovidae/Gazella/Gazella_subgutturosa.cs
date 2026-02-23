namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Gazella;

/// <summary>
/// Species: Gazella subgutturosa
/// NCBI TaxId: 59529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gazella_subgutturosa : Gazella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gazella subgutturosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gazella_subgutturosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59529;
}
