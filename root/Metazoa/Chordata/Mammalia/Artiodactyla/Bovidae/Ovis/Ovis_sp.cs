namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis sp.
/// NCBI TaxId: 9939
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_sp : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9939;
}
