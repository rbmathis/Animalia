namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Macrosphenus;

/// <summary>
/// Species: Macrosphenus flavicans
/// NCBI TaxId: 237426
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrosphenus_flavicans : Macrosphenus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrosphenus flavicans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrosphenus_flavicans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 237426;
}
