namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus;

/// <summary>
/// Species: Naemorhedus griseus
/// NCBI TaxId: 561742
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naemorhedus_griseus : Naemorhedus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naemorhedus griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naemorhedus_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 561742;
}
