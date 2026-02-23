namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Notophthalmus;

/// <summary>
/// Species: Notophthalmus viridescens
/// NCBI TaxId: 8316
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Notophthalmus_viridescens : Notophthalmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Notophthalmus viridescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Notophthalmus_viridescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8316;
}
