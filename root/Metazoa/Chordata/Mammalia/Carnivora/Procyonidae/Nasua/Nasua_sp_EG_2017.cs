namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua;

/// <summary>
/// Species: Nasua sp. EG-2017
/// NCBI TaxId: 1967459
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nasua_sp_EG_2017 : Nasua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nasua sp. EG-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nasua_sp_EG_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1967459;
}
