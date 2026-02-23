namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Loxodonta;

/// <summary>
/// Species: Loxodonta environmental sample
/// NCBI TaxId: 2682740
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loxodonta_environmental_sample : Loxodonta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loxodonta environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loxodonta_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2682740;
}
