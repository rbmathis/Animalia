namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Brachymeles;

/// <summary>
/// Species: Brachymeles tiboliorum
/// NCBI TaxId: 1191204
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachymeles_tiboliorum : Brachymeles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachymeles tiboliorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachymeles_tiboliorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1191204;
}
