namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

/// <summary>
/// Species: Coendou baturitensis
/// NCBI TaxId: 1970184
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coendou_baturitensis : Coendou
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coendou baturitensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coendou_baturitensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1970184;
}
