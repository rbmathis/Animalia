namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emys;

/// <summary>
/// Species: Emys orbicularis
/// NCBI TaxId: 82168
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emys_orbicularis : Emys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emys orbicularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emys_orbicularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 82168;
}
