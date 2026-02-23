namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta maculata
/// NCBI TaxId: 205595
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_maculata : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta maculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_maculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 205595;
}
