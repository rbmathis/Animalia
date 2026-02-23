namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta piscivora
/// NCBI TaxId: 3369998
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_piscivora : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta piscivora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_piscivora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3369998;
}
