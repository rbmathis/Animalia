namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

/// <summary>
/// Species: Merluccius senegalensis
/// NCBI TaxId: 89953
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merluccius_senegalensis : Merluccius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merluccius senegalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merluccius_senegalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89953;
}
