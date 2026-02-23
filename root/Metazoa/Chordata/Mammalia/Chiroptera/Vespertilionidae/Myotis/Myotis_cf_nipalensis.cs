namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis cf. nipalensis
/// NCBI TaxId: 306063
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_cf_nipalensis : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis cf. nipalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_cf_nipalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 306063;
}
