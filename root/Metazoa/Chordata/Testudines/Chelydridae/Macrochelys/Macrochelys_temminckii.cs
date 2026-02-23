namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Macrochelys;

/// <summary>
/// Species: Macrochelys temminckii
/// NCBI TaxId: 571338
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrochelys_temminckii : Macrochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrochelys temminckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrochelys_temminckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 571338;
}
