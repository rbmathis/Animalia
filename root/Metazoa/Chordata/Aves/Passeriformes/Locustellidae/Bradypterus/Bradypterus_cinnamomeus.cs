namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Bradypterus;

/// <summary>
/// Species: Bradypterus cinnamomeus
/// NCBI TaxId: 203787
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bradypterus_cinnamomeus : Bradypterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bradypterus cinnamomeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bradypterus_cinnamomeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 203787;
}
