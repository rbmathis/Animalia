namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Ichthyococcus;

/// <summary>
/// Species: Ichthyococcus elongatus
/// NCBI TaxId: 1633427
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyococcus_elongatus : Ichthyococcus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyococcus elongatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyococcus_elongatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1633427;
}
