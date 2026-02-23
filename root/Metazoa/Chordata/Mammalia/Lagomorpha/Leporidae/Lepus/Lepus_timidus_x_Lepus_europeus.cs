namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus timidus x Lepus europeus
/// NCBI TaxId: 70135
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_timidus_x_Lepus_europeus : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus timidus x Lepus europeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_timidus_x_Lepus_europeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70135;
}
