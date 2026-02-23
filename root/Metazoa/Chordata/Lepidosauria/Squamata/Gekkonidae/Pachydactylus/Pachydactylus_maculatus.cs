namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus;

/// <summary>
/// Species: Pachydactylus maculatus
/// NCBI TaxId: 185350
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachydactylus_maculatus : Pachydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachydactylus maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachydactylus_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 185350;
}
