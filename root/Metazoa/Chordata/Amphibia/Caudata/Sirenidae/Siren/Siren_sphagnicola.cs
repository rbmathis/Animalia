namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Sirenidae.Siren;

/// <summary>
/// Species: Siren sphagnicola
/// NCBI TaxId: 2978768
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Siren_sphagnicola : Siren
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Siren sphagnicola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Siren_sphagnicola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2978768;
}
