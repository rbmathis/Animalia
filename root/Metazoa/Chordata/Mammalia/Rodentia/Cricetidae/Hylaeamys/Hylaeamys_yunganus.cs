namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Hylaeamys;

/// <summary>
/// Species: Hylaeamys yunganus
/// NCBI TaxId: 530176
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylaeamys_yunganus : Hylaeamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylaeamys yunganus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylaeamys_yunganus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 530176;
}
