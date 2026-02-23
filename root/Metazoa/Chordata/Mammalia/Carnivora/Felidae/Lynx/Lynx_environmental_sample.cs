namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx;

/// <summary>
/// Species: Lynx environmental sample
/// NCBI TaxId: 1002257
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lynx_environmental_sample : Lynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lynx environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lynx_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002257;
}
