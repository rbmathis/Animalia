namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Myuchelys;

/// <summary>
/// Species: Myuchelys bellii
/// NCBI TaxId: 904237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myuchelys_bellii : Myuchelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myuchelys bellii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myuchelys_bellii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904237;
}
