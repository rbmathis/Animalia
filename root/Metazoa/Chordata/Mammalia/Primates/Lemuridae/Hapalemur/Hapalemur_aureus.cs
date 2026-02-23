namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Species: Hapalemur aureus
/// NCBI TaxId: 122222
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalemur_aureus : Hapalemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalemur aureus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalemur_aureus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 122222;
}
