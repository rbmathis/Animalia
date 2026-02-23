namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys sp. LLM-2010a
/// NCBI TaxId: 752757
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_sp_LLM_2010a : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys sp. LLM-2010a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_sp_LLM_2010a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 752757;
}
