namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus;

/// <summary>
/// Species: Pachydactylus acuminatus
/// NCBI TaxId: 1960576
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachydactylus_acuminatus : Pachydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachydactylus acuminatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachydactylus_acuminatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1960576;
}
