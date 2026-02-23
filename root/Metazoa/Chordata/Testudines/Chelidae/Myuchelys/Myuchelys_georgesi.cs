namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Myuchelys;

/// <summary>
/// Species: Myuchelys georgesi
/// NCBI TaxId: 1041117
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myuchelys_georgesi : Myuchelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myuchelys georgesi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myuchelys_georgesi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1041117;
}
