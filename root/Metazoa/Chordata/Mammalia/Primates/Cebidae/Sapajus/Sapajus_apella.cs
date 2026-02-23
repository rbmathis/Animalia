namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus;

/// <summary>
/// Species: Sapajus apella
/// NCBI TaxId: 9515
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sapajus_apella : Sapajus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sapajus apella";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sapajus_apella";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9515;
}
