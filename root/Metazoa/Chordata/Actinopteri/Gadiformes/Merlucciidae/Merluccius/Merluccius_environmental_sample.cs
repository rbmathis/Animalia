namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

/// <summary>
/// Species: Merluccius environmental sample
/// NCBI TaxId: 1814136
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merluccius_environmental_sample : Merluccius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merluccius environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merluccius_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814136;
}
