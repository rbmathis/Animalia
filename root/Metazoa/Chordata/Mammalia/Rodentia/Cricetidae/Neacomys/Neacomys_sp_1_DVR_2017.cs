namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

/// <summary>
/// Species: Neacomys sp. 1 DVR-2017
/// NCBI TaxId: 1974208
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neacomys_sp_1_DVR_2017 : Neacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neacomys sp. 1 DVR-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neacomys_sp_1_DVR_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1974208;
}
