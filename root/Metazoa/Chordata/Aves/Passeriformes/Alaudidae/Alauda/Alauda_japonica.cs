namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Alauda;

/// <summary>
/// Species: Alauda japonica
/// NCBI TaxId: 344228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alauda_japonica : Alauda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alauda japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alauda_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 344228;
}
