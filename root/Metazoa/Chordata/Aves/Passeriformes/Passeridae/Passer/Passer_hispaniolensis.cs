namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer hispaniolensis
/// NCBI TaxId: 56115
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_hispaniolensis : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer hispaniolensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_hispaniolensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56115;
}
