namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Myuchelys;

/// <summary>
/// Species: Myuchelys latisternum
/// NCBI TaxId: 1041116
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myuchelys_latisternum : Myuchelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myuchelys latisternum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myuchelys_latisternum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1041116;
}
