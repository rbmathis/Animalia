namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Uroplatus;

/// <summary>
/// Species: Uroplatus sp. giganteus
/// NCBI TaxId: 402386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uroplatus_sp_giganteus : Uroplatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uroplatus sp. giganteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uroplatus_sp_giganteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 402386;
}
