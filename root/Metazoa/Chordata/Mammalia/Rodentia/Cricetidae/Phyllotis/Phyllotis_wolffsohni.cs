namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phyllotis;

/// <summary>
/// Species: Phyllotis wolffsohni
/// NCBI TaxId: 59940
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllotis_wolffsohni : Phyllotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllotis wolffsohni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllotis_wolffsohni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59940;
}
