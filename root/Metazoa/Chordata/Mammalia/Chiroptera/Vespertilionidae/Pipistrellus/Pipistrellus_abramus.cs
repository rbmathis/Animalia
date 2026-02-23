namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus;

/// <summary>
/// Species: Pipistrellus abramus
/// NCBI TaxId: 105295
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipistrellus_abramus : Pipistrellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipistrellus abramus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipistrellus_abramus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 105295;
}
