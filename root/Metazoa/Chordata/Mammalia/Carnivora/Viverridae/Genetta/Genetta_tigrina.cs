namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta tigrina
/// NCBI TaxId: 220101
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_tigrina : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta tigrina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_tigrina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 220101;
}
