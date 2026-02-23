namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus;

/// <summary>
/// Species: Naemorhedus sp.
/// NCBI TaxId: 1479154
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naemorhedus_sp : Naemorhedus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naemorhedus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naemorhedus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1479154;
}
