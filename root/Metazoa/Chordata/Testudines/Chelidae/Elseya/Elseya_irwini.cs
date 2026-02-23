namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya irwini
/// NCBI TaxId: 321139
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_irwini : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya irwini";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_irwini";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 321139;
}
