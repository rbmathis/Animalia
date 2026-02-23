namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus;

/// <summary>
/// Species: Hemidactylus cf. fasciatus
/// NCBI TaxId: 993017
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemidactylus_cf_fasciatus : Hemidactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemidactylus cf. fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemidactylus_cf_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 993017;
}
