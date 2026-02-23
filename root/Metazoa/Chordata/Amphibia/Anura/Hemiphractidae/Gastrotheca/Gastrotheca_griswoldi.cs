namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

/// <summary>
/// Species: Gastrotheca griswoldi
/// NCBI TaxId: 332544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gastrotheca_griswoldi : Gastrotheca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gastrotheca griswoldi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gastrotheca_griswoldi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332544;
}
