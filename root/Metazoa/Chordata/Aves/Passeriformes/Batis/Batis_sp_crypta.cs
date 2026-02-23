namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

/// <summary>
/// Species: Batis sp. crypta
/// NCBI TaxId: 392399
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batis_sp_crypta : Batis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batis sp. crypta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batis_sp_crypta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 392399;
}
