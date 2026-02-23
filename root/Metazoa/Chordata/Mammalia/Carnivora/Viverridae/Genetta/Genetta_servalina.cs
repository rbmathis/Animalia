namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta servalina
/// NCBI TaxId: 205596
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_servalina : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta servalina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_servalina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 205596;
}
