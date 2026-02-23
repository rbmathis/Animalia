namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apomys;

/// <summary>
/// Species: Apomys sp. Mt. Abra de Ilog
/// NCBI TaxId: 2517234
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apomys_sp_Mt_Abra_de_Ilog : Apomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apomys sp. Mt. Abra de Ilog";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apomys_sp_Mt_Abra_de_Ilog";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2517234;
}
