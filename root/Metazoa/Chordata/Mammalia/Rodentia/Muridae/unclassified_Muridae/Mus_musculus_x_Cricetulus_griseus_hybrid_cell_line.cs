namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae;

/// <summary>
/// Species: Mus musculus x Cricetulus griseus hybrid cell line
/// NCBI TaxId: 58329
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_musculus_x_Cricetulus_griseus_hybrid_cell_line : unclassified_Muridae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus musculus x Cricetulus griseus hybrid cell line";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_musculus_x_Cricetulus_griseus_hybrid_cell_line";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 58329;
}
