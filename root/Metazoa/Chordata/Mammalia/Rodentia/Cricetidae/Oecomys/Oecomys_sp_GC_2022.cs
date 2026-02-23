namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys sp. GC-2022
/// NCBI TaxId: 2943536
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_sp_GC_2022 : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys sp. GC-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_sp_GC_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2943536;
}
