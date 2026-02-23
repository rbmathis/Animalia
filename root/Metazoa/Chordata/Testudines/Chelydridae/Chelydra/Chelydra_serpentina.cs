namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Chelydra;

/// <summary>
/// Species: Chelydra serpentina
/// NCBI TaxId: 8475
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelydra_serpentina : Chelydra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelydra serpentina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelydra_serpentina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8475;
}
