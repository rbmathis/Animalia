namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phyllotis;

/// <summary>
/// Species: Phyllotis sp. 1 AO-2021
/// NCBI TaxId: 2804060
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllotis_sp_1_AO_2021 : Phyllotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllotis sp. 1 AO-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllotis_sp_1_AO_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804060;
}
