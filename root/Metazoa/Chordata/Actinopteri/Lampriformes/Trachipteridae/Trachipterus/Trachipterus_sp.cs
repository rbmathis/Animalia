namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Trachipterus;

/// <summary>
/// Species: Trachipterus sp.
/// NCBI TaxId: 3444458
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachipterus_sp : Trachipterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachipterus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachipterus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3444458;
}
