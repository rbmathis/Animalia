namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Gazella;

/// <summary>
/// Species: Gazella gazella
/// NCBI TaxId: 69302
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gazella_gazella : Gazella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gazella gazella";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gazella_gazella";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69302;
}
