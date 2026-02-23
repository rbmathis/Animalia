namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heros;

/// <summary>
/// Species: Heros sp. common FEH-2017
/// NCBI TaxId: 2021347
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heros_sp_common_FEH_2017 : Heros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heros sp. common FEH-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heros_sp_common_FEH_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2021347;
}
