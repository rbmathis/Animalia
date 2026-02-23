namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus;

/// <summary>
/// Species: Pipistrellus cf. kuhlii
/// NCBI TaxId: 1195385
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipistrellus_cf_kuhlii : Pipistrellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipistrellus cf. kuhlii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipistrellus_cf_kuhlii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1195385;
}
