namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus;

/// <summary>
/// Species: Hemidactylus giganteus
/// NCBI TaxId: 863652
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemidactylus_giganteus : Hemidactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemidactylus giganteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemidactylus_giganteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 863652;
}
