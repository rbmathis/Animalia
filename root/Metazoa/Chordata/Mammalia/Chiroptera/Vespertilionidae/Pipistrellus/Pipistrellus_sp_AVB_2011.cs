namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus;

/// <summary>
/// Species: Pipistrellus sp. AVB-2011
/// NCBI TaxId: 1001580
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipistrellus_sp_AVB_2011 : Pipistrellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipistrellus sp. AVB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipistrellus_sp_AVB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1001580;
}
