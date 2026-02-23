namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Rheohyla;

/// <summary>
/// Species: Rheohyla sp. n. FL-2019
/// NCBI TaxId: 2663341
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rheohyla_sp_n_FL_2019 : Rheohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rheohyla sp. n. FL-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rheohyla_sp_n_FL_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2663341;
}
