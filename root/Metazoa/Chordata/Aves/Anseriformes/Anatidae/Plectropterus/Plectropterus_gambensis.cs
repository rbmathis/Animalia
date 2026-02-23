namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Plectropterus;

/// <summary>
/// Species: Plectropterus gambensis
/// NCBI TaxId: 658924
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plectropterus_gambensis : Plectropterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plectropterus gambensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plectropterus_gambensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 658924;
}
