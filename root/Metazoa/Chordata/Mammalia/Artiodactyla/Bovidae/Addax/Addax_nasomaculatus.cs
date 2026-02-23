namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Addax;

/// <summary>
/// Species: Addax nasomaculatus
/// NCBI TaxId: 59515
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Addax_nasomaculatus : Addax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Addax nasomaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Addax_nasomaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59515;
}
