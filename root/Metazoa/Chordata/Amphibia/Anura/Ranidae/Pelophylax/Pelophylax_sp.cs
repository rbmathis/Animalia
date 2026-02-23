namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

/// <summary>
/// Species: Pelophylax sp.
/// NCBI TaxId: 3071454
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelophylax_sp : Pelophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelophylax sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelophylax_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3071454;
}
