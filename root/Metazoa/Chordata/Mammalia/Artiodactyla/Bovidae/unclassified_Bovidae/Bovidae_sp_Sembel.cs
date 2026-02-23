namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.unclassified_Bovidae;

/// <summary>
/// Species: Bovidae sp. Sembel
/// NCBI TaxId: 272462
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bovidae_sp_Sembel : unclassified_Bovidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bovidae sp. Sembel";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bovidae_sp_Sembel";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 272462;
}
