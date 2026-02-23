namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Palaeoloxodon;

/// <summary>
/// Species: Palaeoloxodon sp.
/// NCBI TaxId: 3064006
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Palaeoloxodon_sp : Palaeoloxodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Palaeoloxodon sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Palaeoloxodon_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3064006;
}
