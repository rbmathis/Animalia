namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus ilaeus
/// NCBI TaxId: 1665529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_ilaeus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus ilaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_ilaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1665529;
}
