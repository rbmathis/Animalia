namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo sp. n. IA-2020
/// NCBI TaxId: 2752227
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_sp_n_IA_2020 : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo sp. n. IA-2020";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_sp_n_IA_2020";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2752227;
}
