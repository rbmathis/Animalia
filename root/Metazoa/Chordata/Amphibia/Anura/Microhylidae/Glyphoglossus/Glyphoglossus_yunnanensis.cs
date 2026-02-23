namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Glyphoglossus;

/// <summary>
/// Species: Glyphoglossus yunnanensis
/// NCBI TaxId: 1899508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glyphoglossus_yunnanensis : Glyphoglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glyphoglossus yunnanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glyphoglossus_yunnanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1899508;
}
