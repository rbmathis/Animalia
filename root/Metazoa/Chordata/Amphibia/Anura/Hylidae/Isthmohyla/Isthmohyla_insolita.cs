namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Isthmohyla;

/// <summary>
/// Species: Isthmohyla insolita
/// NCBI TaxId: 3129158
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Isthmohyla_insolita : Isthmohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Isthmohyla insolita";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Isthmohyla_insolita";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3129158;
}
