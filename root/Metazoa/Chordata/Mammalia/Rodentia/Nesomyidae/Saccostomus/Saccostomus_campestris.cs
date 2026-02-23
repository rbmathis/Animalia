namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Saccostomus;

/// <summary>
/// Species: Saccostomus campestris
/// NCBI TaxId: 122953
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saccostomus_campestris : Saccostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saccostomus campestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saccostomus_campestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 122953;
}
