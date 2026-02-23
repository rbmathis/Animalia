namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Species: Hapalemur griseus
/// NCBI TaxId: 13557
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalemur_griseus : Hapalemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalemur griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalemur_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13557;
}
