namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eothenomys;

/// <summary>
/// Species: Eothenomys sp. 1 SJS-2017
/// NCBI TaxId: 2028315
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eothenomys_sp_1_SJS_2017 : Eothenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eothenomys sp. 1 SJS-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eothenomys_sp_1_SJS_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2028315;
}
