namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

/// <summary>
/// Species: Merluccius vulgaris
/// NCBI TaxId: 30756
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merluccius_vulgaris : Merluccius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merluccius vulgaris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merluccius_vulgaris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30756;
}
