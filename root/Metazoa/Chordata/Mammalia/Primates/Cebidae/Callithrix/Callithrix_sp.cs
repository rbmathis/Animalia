namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callithrix;

/// <summary>
/// Species: Callithrix sp.
/// NCBI TaxId: 9485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callithrix_sp : Callithrix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callithrix sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callithrix_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9485;
}
