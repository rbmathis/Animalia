namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Lepilemur;

/// <summary>
/// Species: Lepilemur ruficaudatus
/// NCBI TaxId: 78866
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepilemur_ruficaudatus : Lepilemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepilemur ruficaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepilemur_ruficaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 78866;
}
