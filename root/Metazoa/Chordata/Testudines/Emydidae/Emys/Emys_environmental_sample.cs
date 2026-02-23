namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emys;

/// <summary>
/// Species: Emys environmental sample
/// NCBI TaxId: 2715120
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emys_environmental_sample : Emys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emys environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emys_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2715120;
}
