namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ranitomeya;

/// <summary>
/// Species: Ranitomeya imitator
/// NCBI TaxId: 111125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ranitomeya_imitator : Ranitomeya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ranitomeya imitator";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ranitomeya_imitator";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111125;
}
