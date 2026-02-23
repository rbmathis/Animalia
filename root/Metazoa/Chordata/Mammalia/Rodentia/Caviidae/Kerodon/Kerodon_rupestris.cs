namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Kerodon;

/// <summary>
/// Species: Kerodon rupestris
/// NCBI TaxId: 181539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kerodon_rupestris : Kerodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kerodon rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kerodon_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 181539;
}
