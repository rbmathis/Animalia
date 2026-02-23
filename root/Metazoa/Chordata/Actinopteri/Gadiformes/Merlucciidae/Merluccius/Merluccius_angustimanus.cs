namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

/// <summary>
/// Species: Merluccius angustimanus
/// NCBI TaxId: 247647
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merluccius_angustimanus : Merluccius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merluccius angustimanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merluccius_angustimanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 247647;
}
