namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Oenanthe;

/// <summary>
/// Species: Oenanthe pileata
/// NCBI TaxId: 391715
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oenanthe_pileata : Oenanthe
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oenanthe pileata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oenanthe_pileata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 391715;
}
