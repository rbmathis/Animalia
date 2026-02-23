namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus;

/// <summary>
/// Species: Hemidactylus laticaudatus
/// NCBI TaxId: 3146649
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemidactylus_laticaudatus : Hemidactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemidactylus laticaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemidactylus_laticaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3146649;
}
