namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

/// <summary>
/// Species: Genetta sp. BDP7276_FMNH
/// NCBI TaxId: 3027311
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Genetta_sp_BDP7276_FMNH : Genetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Genetta sp. BDP7276_FMNH";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Genetta_sp_BDP7276_FMNH";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3027311;
}
