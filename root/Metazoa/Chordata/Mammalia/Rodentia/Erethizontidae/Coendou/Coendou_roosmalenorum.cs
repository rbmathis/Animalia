namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

/// <summary>
/// Species: Coendou roosmalenorum
/// NCBI TaxId: 3074399
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coendou_roosmalenorum : Coendou
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coendou roosmalenorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coendou_roosmalenorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3074399;
}
