namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Hylaeamys;

/// <summary>
/// Species: Hylaeamys acritus
/// NCBI TaxId: 379650
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylaeamys_acritus : Hylaeamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylaeamys acritus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylaeamys_acritus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 379650;
}
