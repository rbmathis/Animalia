namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Spondylurus;

/// <summary>
/// Species: Spondylurus culebrae
/// NCBI TaxId: 1190649
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spondylurus_culebrae : Spondylurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spondylurus culebrae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spondylurus_culebrae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1190649;
}
