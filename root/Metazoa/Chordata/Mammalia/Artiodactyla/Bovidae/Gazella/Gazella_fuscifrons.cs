namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Gazella;

/// <summary>
/// Species: Gazella fuscifrons
/// NCBI TaxId: 3569950
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gazella_fuscifrons : Gazella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gazella fuscifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gazella_fuscifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3569950;
}
