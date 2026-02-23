namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca radiata
/// NCBI TaxId: 9548
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_radiata : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca radiata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_radiata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9548;
}
