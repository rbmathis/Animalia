namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Mammalia;

/// <summary>
/// Species: Homo sapiens x Cricetulus griseus hybrid cell line
/// NCBI TaxId: 1849111
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homo_sapiens_x_Cricetulus_griseus_hybrid_cell_line : unclassified_Mammalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homo sapiens x Cricetulus griseus hybrid cell line";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homo_sapiens_x_Cricetulus_griseus_hybrid_cell_line";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1849111;
}
