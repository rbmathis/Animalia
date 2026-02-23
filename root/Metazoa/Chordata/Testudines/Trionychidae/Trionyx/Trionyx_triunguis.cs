namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Trionyx;

/// <summary>
/// Species: Trionyx triunguis
/// NCBI TaxId: 101491
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trionyx_triunguis : Trionyx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trionyx triunguis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trionyx_triunguis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 101491;
}
