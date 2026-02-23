namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Deltamys;

/// <summary>
/// Species: Deltamys sp. Esmeralda/GDE-2011
/// NCBI TaxId: 1096280
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Deltamys_sp_EsmeraldaGDE_2011 : Deltamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Deltamys sp. Esmeralda/GDE-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Deltamys_sp_EsmeraldaGDE_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1096280;
}
