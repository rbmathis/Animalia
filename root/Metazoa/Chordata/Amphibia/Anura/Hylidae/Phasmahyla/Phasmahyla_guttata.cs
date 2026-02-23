namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phasmahyla;

/// <summary>
/// Species: Phasmahyla guttata
/// NCBI TaxId: 318407
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phasmahyla_guttata : Phasmahyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phasmahyla guttata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phasmahyla_guttata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318407;
}
