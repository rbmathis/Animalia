namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myopus;

/// <summary>
/// Species: Myopus schisticolor
/// NCBI TaxId: 71003
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myopus_schisticolor : Myopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myopus schisticolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myopus_schisticolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 71003;
}
