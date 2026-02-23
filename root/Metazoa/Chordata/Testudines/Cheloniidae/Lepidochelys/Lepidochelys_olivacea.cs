namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys;

/// <summary>
/// Species: Lepidochelys olivacea
/// NCBI TaxId: 27788
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidochelys_olivacea : Lepidochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidochelys olivacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidochelys_olivacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27788;
}
