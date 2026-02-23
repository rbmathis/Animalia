namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bromeliohyla;

/// <summary>
/// Species: Bromeliohyla melacaena
/// NCBI TaxId: 2491324
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bromeliohyla_melacaena : Bromeliohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bromeliohyla melacaena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bromeliohyla_melacaena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2491324;
}
