namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus;

/// <summary>
/// Species: Plecotus sp.
/// NCBI TaxId: 232091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plecotus_sp : Plecotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plecotus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plecotus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 232091;
}
