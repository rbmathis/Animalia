namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis.Panurus;

/// <summary>
/// Species: Panurus biarmicus
/// NCBI TaxId: 181101
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Panurus_biarmicus : Panurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Panurus biarmicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Panurus_biarmicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 181101;
}
