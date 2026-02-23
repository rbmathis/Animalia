namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus liechtensteini
/// NCBI TaxId: 137714
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_liechtensteini : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus liechtensteini";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_liechtensteini";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 137714;
}
