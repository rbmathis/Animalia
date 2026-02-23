namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

/// <summary>
/// Species: Hyperolius steindachneri
/// NCBI TaxId: 1138065
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyperolius_steindachneri : Hyperolius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyperolius steindachneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyperolius_steindachneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1138065;
}
