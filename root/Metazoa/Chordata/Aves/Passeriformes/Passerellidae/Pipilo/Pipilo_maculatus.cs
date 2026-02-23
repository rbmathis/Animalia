namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pipilo;

/// <summary>
/// Species: Pipilo maculatus
/// NCBI TaxId: 95650
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipilo_maculatus : Pipilo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipilo maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipilo_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95650;
}
