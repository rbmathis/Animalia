namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetrao;

/// <summary>
/// Species: Tetrao parvirostris
/// NCBI TaxId: 109672
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tetrao_parvirostris : Tetrao
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tetrao parvirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tetrao_parvirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109672;
}
