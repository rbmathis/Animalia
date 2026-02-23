namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Steatomys;

/// <summary>
/// Species: Steatomys sp.
/// NCBI TaxId: 81634
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Steatomys_sp : Steatomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Steatomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Steatomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81634;
}
