namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

/// <summary>
/// Species: Pelophylax sp. JP-2012
/// NCBI TaxId: 1194502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelophylax_sp_JP_2012 : Pelophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelophylax sp. JP-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelophylax_sp_JP_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1194502;
}
