namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Thorius;

/// <summary>
/// Species: Thorius sp. San Juan del Estado
/// NCBI TaxId: 3079733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thorius_sp_San_Juan_del_Estado : Thorius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thorius sp. San Juan del Estado";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thorius_sp_San_Juan_del_Estado";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3079733;
}
