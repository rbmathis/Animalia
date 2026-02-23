namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta stramineus
/// NCBI TaxId: 163110
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_stramineus : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta stramineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_stramineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 163110;
}
