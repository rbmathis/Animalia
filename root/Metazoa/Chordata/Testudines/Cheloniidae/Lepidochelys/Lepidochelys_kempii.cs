namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys;

/// <summary>
/// Species: Lepidochelys kempii
/// NCBI TaxId: 8472
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidochelys_kempii : Lepidochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidochelys kempii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidochelys_kempii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8472;
}
