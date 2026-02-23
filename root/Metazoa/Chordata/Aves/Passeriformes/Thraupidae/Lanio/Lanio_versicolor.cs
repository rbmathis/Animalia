namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Lanio;

/// <summary>
/// Species: Lanio versicolor
/// NCBI TaxId: 62217
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lanio_versicolor : Lanio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lanio versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lanio_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62217;
}
