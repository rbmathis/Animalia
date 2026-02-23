namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Sula;

/// <summary>
/// Species: Sula leucogaster
/// NCBI TaxId: 57661
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sula_leucogaster : Sula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sula leucogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sula_leucogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57661;
}
