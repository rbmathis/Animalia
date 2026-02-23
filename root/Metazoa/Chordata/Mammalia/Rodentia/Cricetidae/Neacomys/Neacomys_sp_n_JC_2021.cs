namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

/// <summary>
/// Species: Neacomys sp. n. JC-2021
/// NCBI TaxId: 2822522
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neacomys_sp_n_JC_2021 : Neacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neacomys sp. n. JC-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neacomys_sp_n_JC_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2822522;
}
