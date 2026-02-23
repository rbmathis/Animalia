namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cycloderma;

/// <summary>
/// Species: Cycloderma aubryi
/// NCBI TaxId: 227465
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cycloderma_aubryi : Cycloderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cycloderma aubryi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cycloderma_aubryi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227465;
}
