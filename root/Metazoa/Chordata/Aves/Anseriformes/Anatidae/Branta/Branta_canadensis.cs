namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta canadensis
/// NCBI TaxId: 8853
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_canadensis : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8853;
}
