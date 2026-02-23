namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Murina;

/// <summary>
/// Species: Murina sp. A CMF-2010
/// NCBI TaxId: 867846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Murina_sp_A_CMF_2010 : Murina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Murina sp. A CMF-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Murina_sp_A_CMF_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867846;
}
