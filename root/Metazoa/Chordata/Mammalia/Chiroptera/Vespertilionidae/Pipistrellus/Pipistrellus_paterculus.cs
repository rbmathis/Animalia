namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus;

/// <summary>
/// Species: Pipistrellus paterculus
/// NCBI TaxId: 867883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipistrellus_paterculus : Pipistrellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipistrellus paterculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipistrellus_paterculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867883;
}
