namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lemniscomys;

/// <summary>
/// Species: Lemniscomys striatus
/// NCBI TaxId: 121567
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemniscomys_striatus : Lemniscomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemniscomys striatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemniscomys_striatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121567;
}
