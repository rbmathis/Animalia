namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.unclassified_Hominidae;

/// <summary>
/// Species: Hominidae sp.
/// NCBI TaxId: 2922388
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hominidae_sp : unclassified_Hominidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hominidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hominidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2922388;
}
