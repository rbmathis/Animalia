namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Antechinus;

/// <summary>
/// Species: Antechinus stuartii
/// NCBI TaxId: 9283
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Antechinus_stuartii : Antechinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Antechinus stuartii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Antechinus_stuartii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9283;
}
