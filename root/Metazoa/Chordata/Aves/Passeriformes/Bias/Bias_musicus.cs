namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bias;

/// <summary>
/// Species: Bias musicus
/// NCBI TaxId: 272806
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bias_musicus : Bias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bias musicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bias_musicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 272806;
}
