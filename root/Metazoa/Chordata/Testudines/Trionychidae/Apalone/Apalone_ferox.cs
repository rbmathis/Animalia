namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Apalone;

/// <summary>
/// Species: Apalone ferox
/// NCBI TaxId: 100213
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apalone_ferox : Apalone
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apalone ferox";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apalone_ferox";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100213;
}
