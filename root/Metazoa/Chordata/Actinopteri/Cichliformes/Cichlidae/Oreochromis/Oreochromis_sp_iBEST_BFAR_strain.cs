namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

/// <summary>
/// Species: Oreochromis sp. iBEST BFAR strain
/// NCBI TaxId: 2315961
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreochromis_sp_iBEST_BFAR_strain : Oreochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreochromis sp. iBEST BFAR strain";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreochromis_sp_iBEST_BFAR_strain";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2315961;
}
