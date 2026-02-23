namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Rhinophis;

/// <summary>
/// Species: Rhinophis tricoloratus
/// NCBI TaxId: 2976563
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinophis_tricoloratus : Rhinophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinophis tricoloratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinophis_tricoloratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2976563;
}
