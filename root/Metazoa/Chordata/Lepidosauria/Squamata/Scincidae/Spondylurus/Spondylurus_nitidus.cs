namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Spondylurus;

/// <summary>
/// Species: Spondylurus nitidus
/// NCBI TaxId: 3095121
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spondylurus_nitidus : Spondylurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spondylurus nitidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spondylurus_nitidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3095121;
}
