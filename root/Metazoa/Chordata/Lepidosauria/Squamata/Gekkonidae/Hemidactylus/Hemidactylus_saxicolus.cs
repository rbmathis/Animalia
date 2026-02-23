namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus;

/// <summary>
/// Species: Hemidactylus saxicolus
/// NCBI TaxId: 2934760
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemidactylus_saxicolus : Hemidactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemidactylus saxicolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemidactylus_saxicolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2934760;
}
