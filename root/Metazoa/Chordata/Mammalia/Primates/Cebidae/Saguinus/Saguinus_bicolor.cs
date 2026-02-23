namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus bicolor
/// NCBI TaxId: 37588
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_bicolor : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus bicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_bicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37588;
}
