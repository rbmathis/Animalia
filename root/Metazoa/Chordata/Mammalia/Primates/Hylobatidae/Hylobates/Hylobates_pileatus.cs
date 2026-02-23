namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Species: Hylobates pileatus
/// NCBI TaxId: 9589
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylobates_pileatus : Hylobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylobates pileatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylobates_pileatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9589;
}
