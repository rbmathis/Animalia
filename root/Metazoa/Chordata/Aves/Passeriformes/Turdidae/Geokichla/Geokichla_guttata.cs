namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Geokichla;

/// <summary>
/// Species: Geokichla guttata
/// NCBI TaxId: 3149909
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geokichla_guttata : Geokichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geokichla guttata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geokichla_guttata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149909;
}
