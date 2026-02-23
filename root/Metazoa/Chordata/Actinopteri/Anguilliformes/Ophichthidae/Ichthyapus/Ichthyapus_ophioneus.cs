namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ichthyapus;

/// <summary>
/// Species: Ichthyapus ophioneus
/// NCBI TaxId: 182433
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyapus_ophioneus : Ichthyapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyapus ophioneus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyapus_ophioneus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 182433;
}
