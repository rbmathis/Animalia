namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Corvus;

/// <summary>
/// Species: Corvus corone x Corvus cornix
/// NCBI TaxId: 2763642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corvus_corone_x_Corvus_cornix : Corvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corvus corone x Corvus cornix";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corvus_corone_x_Corvus_cornix";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2763642;
}
