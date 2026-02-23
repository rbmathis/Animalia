namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Lepilemur;

/// <summary>
/// Species: Lepilemur mustelinus
/// NCBI TaxId: 9453
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepilemur_mustelinus : Lepilemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepilemur mustelinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepilemur_mustelinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9453;
}
