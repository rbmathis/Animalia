namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallinula;

/// <summary>
/// Species: Gallinula galeata
/// NCBI TaxId: 1003838
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gallinula_galeata : Gallinula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gallinula galeata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gallinula_galeata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003838;
}
