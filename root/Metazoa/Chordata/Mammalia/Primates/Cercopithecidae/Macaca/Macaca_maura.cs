namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca maura
/// NCBI TaxId: 90383
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_maura : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca maura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_maura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 90383;
}
