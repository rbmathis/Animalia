namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Hylaeamys;

/// <summary>
/// Species: Hylaeamys tatei
/// NCBI TaxId: 2053720
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylaeamys_tatei : Hylaeamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylaeamys tatei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylaeamys_tatei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2053720;
}
