namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Carcharodon;

/// <summary>
/// Species: Carcharodon carcharias
/// NCBI TaxId: 13397
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carcharodon_carcharias : Carcharodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carcharodon carcharias";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carcharodon_carcharias";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13397;
}
