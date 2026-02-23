namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Amaurornis;

/// <summary>
/// Species: Amaurornis magnirostris
/// NCBI TaxId: 3149351
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amaurornis_magnirostris : Amaurornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amaurornis magnirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amaurornis_magnirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149351;
}
