namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tachyeres;

/// <summary>
/// Species: Tachyeres patachonicus
/// NCBI TaxId: 658927
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachyeres_patachonicus : Tachyeres
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachyeres patachonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachyeres_patachonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 658927;
}
