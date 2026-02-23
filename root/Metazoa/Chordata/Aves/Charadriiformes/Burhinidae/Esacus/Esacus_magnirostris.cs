namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Esacus;

/// <summary>
/// Species: Esacus magnirostris
/// NCBI TaxId: 2577026
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Esacus_magnirostris : Esacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Esacus magnirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Esacus_magnirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2577026;
}
