namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tatera;

/// <summary>
/// Species: Tatera indica
/// NCBI TaxId: 186471
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tatera_indica : Tatera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tatera indica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tatera_indica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 186471;
}
