namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Mammalia;

/// <summary>
/// Species: Mus musculus x Rattus norvegicus hybrid cell line
/// NCBI TaxId: 1849109
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_musculus_x_Rattus_norvegicus_hybrid_cell_line : unclassified_Mammalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus musculus x Rattus norvegicus hybrid cell line";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_musculus_x_Rattus_norvegicus_hybrid_cell_line";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1849109;
}
