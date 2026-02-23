namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus;

/// <summary>
/// Species: Pachydactylus kochii
/// NCBI TaxId: 1208027
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachydactylus_kochii : Pachydactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachydactylus kochii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachydactylus_kochii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1208027;
}
