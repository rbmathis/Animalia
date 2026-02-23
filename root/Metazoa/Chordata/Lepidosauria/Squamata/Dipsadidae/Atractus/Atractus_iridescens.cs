namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Atractus;

/// <summary>
/// Species: Atractus iridescens
/// NCBI TaxId: 1785745
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atractus_iridescens : Atractus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atractus iridescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atractus_iridescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1785745;
}
