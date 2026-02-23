namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria;

/// <summary>
/// Species: Manouria impressa
/// NCBI TaxId: 74924
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manouria_impressa : Manouria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manouria impressa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manouria_impressa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74924;
}
