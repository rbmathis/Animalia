namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ichthyapus;

/// <summary>
/// Species: Ichthyapus vulturis
/// NCBI TaxId: 3040420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyapus_vulturis : Ichthyapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyapus vulturis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyapus_vulturis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3040420;
}
