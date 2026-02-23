namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Chelydra;

/// <summary>
/// Species: Chelydra rossignonii
/// NCBI TaxId: 904183
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelydra_rossignonii : Chelydra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelydra rossignonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelydra_rossignonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904183;
}
