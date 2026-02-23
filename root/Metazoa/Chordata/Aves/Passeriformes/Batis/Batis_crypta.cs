namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

/// <summary>
/// Species: Batis crypta
/// NCBI TaxId: 1112834
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batis_crypta : Batis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batis crypta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batis_crypta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1112834;
}
