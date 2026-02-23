namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Melanomys;

/// <summary>
/// Species: Melanomys cf. idoneus SJS-2017
/// NCBI TaxId: 2028319
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melanomys_cf_idoneus_SJS_2017 : Melanomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melanomys cf. idoneus SJS-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melanomys_cf_idoneus_SJS_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2028319;
}
