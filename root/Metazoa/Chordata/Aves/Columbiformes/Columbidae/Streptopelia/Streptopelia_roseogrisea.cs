namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Streptopelia;

/// <summary>
/// Species: Streptopelia roseogrisea
/// NCBI TaxId: 177152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Streptopelia_roseogrisea : Streptopelia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Streptopelia roseogrisea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Streptopelia_roseogrisea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 177152;
}
