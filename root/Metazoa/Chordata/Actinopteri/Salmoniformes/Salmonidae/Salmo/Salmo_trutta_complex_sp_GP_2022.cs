namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo trutta complex sp. GP-2022
/// NCBI TaxId: 2928103
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_trutta_complex_sp_GP_2022 : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo trutta complex sp. GP-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_trutta_complex_sp_GP_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2928103;
}
