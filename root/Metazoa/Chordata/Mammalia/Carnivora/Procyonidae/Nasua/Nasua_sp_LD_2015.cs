namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua;

/// <summary>
/// Species: Nasua sp. LD-2015
/// NCBI TaxId: 1704005
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nasua_sp_LD_2015 : Nasua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nasua sp. LD-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nasua_sp_LD_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1704005;
}
