namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Pharomachrus;

/// <summary>
/// Species: Pharomachrus auriceps
/// NCBI TaxId: 59410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pharomachrus_auriceps : Pharomachrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pharomachrus auriceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pharomachrus_auriceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59410;
}
