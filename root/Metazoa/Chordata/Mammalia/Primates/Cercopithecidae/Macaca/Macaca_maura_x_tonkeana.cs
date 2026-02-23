namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca maura x tonkeana
/// NCBI TaxId: 168259
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_maura_x_tonkeana : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca maura x tonkeana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_maura_x_tonkeana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 168259;
}
