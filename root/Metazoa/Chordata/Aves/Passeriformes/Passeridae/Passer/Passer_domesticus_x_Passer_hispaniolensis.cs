namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer domesticus x Passer hispaniolensis
/// NCBI TaxId: 1910948
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_domesticus_x_Passer_hispaniolensis : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer domesticus x Passer hispaniolensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_domesticus_x_Passer_hispaniolensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1910948;
}
