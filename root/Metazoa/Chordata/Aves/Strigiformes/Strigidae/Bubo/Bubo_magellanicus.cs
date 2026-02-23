namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo;

/// <summary>
/// Species: Bubo magellanicus
/// NCBI TaxId: 126881
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubo_magellanicus : Bubo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubo magellanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubo_magellanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126881;
}
