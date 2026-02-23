namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Melanochelys;

/// <summary>
/// Species: Melanochelys trijuga
/// NCBI TaxId: 74938
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melanochelys_trijuga : Melanochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melanochelys trijuga";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melanochelys_trijuga";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 74938;
}
