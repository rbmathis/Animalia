namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis cf. aurascens
/// NCBI TaxId: 1195384
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_cf_aurascens : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis cf. aurascens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_cf_aurascens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1195384;
}
