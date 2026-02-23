namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cycloderma;

/// <summary>
/// Species: Cycloderma frenatum
/// NCBI TaxId: 227464
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cycloderma_frenatum : Cycloderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cycloderma frenatum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cycloderma_frenatum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227464;
}
