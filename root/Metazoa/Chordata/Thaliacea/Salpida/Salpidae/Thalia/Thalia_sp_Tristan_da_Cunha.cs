namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Thalia;

/// <summary>
/// Species: Thalia sp. 'Tristan da Cunha'
/// NCBI TaxId: 1408228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thalia_sp_Tristan_da_Cunha : Thalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thalia sp. 'Tristan da Cunha'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thalia_sp_Tristan_da_Cunha";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1408228;
}
