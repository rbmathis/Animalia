namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Caprimulgus;

/// <summary>
/// Species: Caprimulgus vexillarius
/// NCBI TaxId: 3149528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Caprimulgus_vexillarius : Caprimulgus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Caprimulgus vexillarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Caprimulgus_vexillarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149528;
}
