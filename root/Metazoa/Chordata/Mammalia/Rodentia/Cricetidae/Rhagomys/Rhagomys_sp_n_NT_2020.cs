namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhagomys;

/// <summary>
/// Species: Rhagomys sp. n. NT-2020
/// NCBI TaxId: 2782733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhagomys_sp_n_NT_2020 : Rhagomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhagomys sp. n. NT-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhagomys_sp_n_NT_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2782733;
}
