namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Apalone;

/// <summary>
/// Species: Apalone spinifera
/// NCBI TaxId: 55534
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apalone_spinifera : Apalone
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apalone spinifera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apalone_spinifera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55534;
}
