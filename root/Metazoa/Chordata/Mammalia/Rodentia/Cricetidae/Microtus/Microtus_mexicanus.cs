namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus mexicanus
/// NCBI TaxId: 79689
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_mexicanus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79689;
}
