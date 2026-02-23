namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis cf. thysanodes
/// NCBI TaxId: 1239429
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_cf_thysanodes : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis cf. thysanodes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_cf_thysanodes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1239429;
}
