namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Pitta;

/// <summary>
/// Species: Pitta versicolor
/// NCBI TaxId: 182340
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pitta_versicolor : Pitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pitta versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pitta_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 182340;
}
