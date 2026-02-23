namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Callosciurus;

/// <summary>
/// Species: Callosciurus finlaysonii
/// NCBI TaxId: 127500
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callosciurus_finlaysonii : Callosciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callosciurus finlaysonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callosciurus_finlaysonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 127500;
}
