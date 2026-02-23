namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus;

/// <summary>
/// Species: Pachydactylus scutatus
/// NCBI TaxId: 202849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachydactylus_scutatus : Pachydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachydactylus scutatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachydactylus_scutatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 202849;
}
