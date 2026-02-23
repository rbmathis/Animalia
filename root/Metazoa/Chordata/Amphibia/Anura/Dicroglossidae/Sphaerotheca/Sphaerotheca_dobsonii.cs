namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Sphaerotheca;

/// <summary>
/// Species: Sphaerotheca dobsonii
/// NCBI TaxId: 143592
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphaerotheca_dobsonii : Sphaerotheca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphaerotheca dobsonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphaerotheca_dobsonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143592;
}
