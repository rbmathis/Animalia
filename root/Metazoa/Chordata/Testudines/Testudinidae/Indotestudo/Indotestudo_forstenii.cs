namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Indotestudo;

/// <summary>
/// Species: Indotestudo forstenii
/// NCBI TaxId: 260613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indotestudo_forstenii : Indotestudo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indotestudo forstenii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indotestudo_forstenii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260613;
}
