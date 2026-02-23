namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea;

/// <summary>
/// Species: Galea musteloides
/// NCBI TaxId: 10146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galea_musteloides : Galea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galea musteloides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galea_musteloides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10146;
}
