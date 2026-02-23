namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Ahaetulla;

/// <summary>
/// Species: Ahaetulla flavescens
/// NCBI TaxId: 2884527
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ahaetulla_flavescens : Ahaetulla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ahaetulla flavescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ahaetulla_flavescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2884527;
}
