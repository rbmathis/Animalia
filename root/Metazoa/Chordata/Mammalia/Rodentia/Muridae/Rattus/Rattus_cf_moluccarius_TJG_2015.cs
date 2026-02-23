namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus cf. moluccarius TJG-2015
/// NCBI TaxId: 1676171
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_cf_moluccarius_TJG_2015 : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus cf. moluccarius TJG-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_cf_moluccarius_TJG_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1676171;
}
