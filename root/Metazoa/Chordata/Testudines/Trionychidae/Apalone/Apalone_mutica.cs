namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Apalone;

/// <summary>
/// Species: Apalone mutica
/// NCBI TaxId: 101490
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apalone_mutica : Apalone
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apalone mutica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apalone_mutica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 101490;
}
