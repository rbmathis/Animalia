namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Fregetta;

/// <summary>
/// Species: Fregetta maoriana
/// NCBI TaxId: 1112029
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Fregetta_maoriana : Fregetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Fregetta maoriana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Fregetta_maoriana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1112029;
}
