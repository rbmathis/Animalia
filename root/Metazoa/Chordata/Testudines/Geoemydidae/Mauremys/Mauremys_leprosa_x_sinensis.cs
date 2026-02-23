namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys leprosa x sinensis
/// NCBI TaxId: 2781758
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_leprosa_x_sinensis : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys leprosa x sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_leprosa_x_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2781758;
}
