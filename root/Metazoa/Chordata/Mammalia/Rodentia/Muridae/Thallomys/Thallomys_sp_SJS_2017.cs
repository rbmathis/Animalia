namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thallomys;

/// <summary>
/// Species: Thallomys sp. SJS-2017
/// NCBI TaxId: 2028313
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thallomys_sp_SJS_2017 : Thallomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thallomys sp. SJS-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thallomys_sp_SJS_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2028313;
}
