namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Hystrix;

/// <summary>
/// Species: Hystrix sp. AG-2017
/// NCBI TaxId: 1960321
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hystrix_sp_AG_2017 : Hystrix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hystrix sp. AG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hystrix_sp_AG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1960321;
}
