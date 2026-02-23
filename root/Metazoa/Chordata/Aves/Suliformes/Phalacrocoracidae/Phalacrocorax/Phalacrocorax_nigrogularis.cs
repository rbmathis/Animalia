namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae.Phalacrocorax;

/// <summary>
/// Species: Phalacrocorax nigrogularis
/// NCBI TaxId: 170405
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalacrocorax_nigrogularis : Phalacrocorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalacrocorax nigrogularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalacrocorax_nigrogularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 170405;
}
