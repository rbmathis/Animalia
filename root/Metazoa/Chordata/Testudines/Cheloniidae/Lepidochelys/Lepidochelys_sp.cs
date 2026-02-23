namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys;

/// <summary>
/// Species: Lepidochelys sp.
/// NCBI TaxId: 213158
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidochelys_sp : Lepidochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidochelys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidochelys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213158;
}
