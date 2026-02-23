namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermochelyidae.Dermochelys;

/// <summary>
/// Species: Dermochelys coriacea
/// NCBI TaxId: 27794
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dermochelys_coriacea : Dermochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dermochelys coriacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dermochelys_coriacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27794;
}
