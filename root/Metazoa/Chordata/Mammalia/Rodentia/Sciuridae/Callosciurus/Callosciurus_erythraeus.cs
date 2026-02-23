namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Callosciurus;

/// <summary>
/// Species: Callosciurus erythraeus
/// NCBI TaxId: 64677
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callosciurus_erythraeus : Callosciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callosciurus erythraeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callosciurus_erythraeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 64677;
}
