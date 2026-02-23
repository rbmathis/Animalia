namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Malacochersus;

/// <summary>
/// Species: Malacochersus tornieri
/// NCBI TaxId: 286009
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malacochersus_tornieri : Malacochersus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malacochersus tornieri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malacochersus_tornieri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286009;
}
