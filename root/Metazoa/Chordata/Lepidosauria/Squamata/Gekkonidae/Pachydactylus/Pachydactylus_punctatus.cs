namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus;

/// <summary>
/// Species: Pachydactylus punctatus
/// NCBI TaxId: 185352
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachydactylus_punctatus : Pachydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachydactylus punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachydactylus_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 185352;
}
