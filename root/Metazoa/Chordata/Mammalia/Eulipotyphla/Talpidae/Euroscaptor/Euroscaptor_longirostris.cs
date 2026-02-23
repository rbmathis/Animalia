namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Euroscaptor;

/// <summary>
/// Species: Euroscaptor longirostris
/// NCBI TaxId: 481574
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euroscaptor_longirostris : Euroscaptor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euroscaptor longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euroscaptor_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 481574;
}
