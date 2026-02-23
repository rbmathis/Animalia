namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Deltamys;

/// <summary>
/// Species: Deltamys sp. LLM-2010a
/// NCBI TaxId: 752754
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Deltamys_sp_LLM_2010a : Deltamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Deltamys sp. LLM-2010a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Deltamys_sp_LLM_2010a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 752754;
}
