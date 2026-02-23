namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Ambystomatidae.Ambystoma;

/// <summary>
/// Species: Ambystoma californiense x Ambystoma tigrinum
/// NCBI TaxId: 219712
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ambystoma_californiense_x_Ambystoma_tigrinum : Ambystoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ambystoma californiense x Ambystoma tigrinum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ambystoma_californiense_x_Ambystoma_tigrinum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 219712;
}
