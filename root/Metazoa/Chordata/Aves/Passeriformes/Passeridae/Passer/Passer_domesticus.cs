namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer domesticus
/// NCBI TaxId: 48849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_domesticus : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer domesticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_domesticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48849;
}
