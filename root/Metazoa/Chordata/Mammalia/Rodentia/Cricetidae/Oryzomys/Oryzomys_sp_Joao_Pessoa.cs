namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys;

/// <summary>
/// Species: Oryzomys sp. Joao Pessoa
/// NCBI TaxId: 132255
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryzomys_sp_Joao_Pessoa : Oryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryzomys sp. Joao Pessoa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryzomys_sp_Joao_Pessoa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 132255;
}
