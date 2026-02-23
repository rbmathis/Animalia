namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phyllotis;

/// <summary>
/// Species: Phyllotis amicus
/// NCBI TaxId: 59934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllotis_amicus : Phyllotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllotis amicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllotis_amicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59934;
}
