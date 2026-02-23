namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.unclassified_Bovidae;

/// <summary>
/// Species: Bovidae sp.
/// NCBI TaxId: 3119508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bovidae_sp : unclassified_Bovidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bovidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bovidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3119508;
}
