namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Grampus;

/// <summary>
/// Species: Grampus griseus
/// NCBI TaxId: 83653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grampus_griseus : Grampus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grampus griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grampus_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 83653;
}
