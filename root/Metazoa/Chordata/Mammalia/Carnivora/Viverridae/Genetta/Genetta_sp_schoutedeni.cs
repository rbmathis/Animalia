namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta sp. schoutedeni
/// NCBI TaxId: 235209
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_sp_schoutedeni : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta sp. schoutedeni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_sp_schoutedeni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 235209;
}
