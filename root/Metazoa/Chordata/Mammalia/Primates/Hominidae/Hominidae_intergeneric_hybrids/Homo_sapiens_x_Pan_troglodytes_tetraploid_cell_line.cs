namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Hominidae_intergeneric_hybrids;

/// <summary>
/// Species: Homo sapiens x Pan troglodytes tetraploid cell line
/// NCBI TaxId: 2883641
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homo_sapiens_x_Pan_troglodytes_tetraploid_cell_line : Hominidae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homo sapiens x Pan troglodytes tetraploid cell line";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homo_sapiens_x_Pan_troglodytes_tetraploid_cell_line";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2883641;
}
