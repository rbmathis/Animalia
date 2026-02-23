namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sphaenorhynchus;

/// <summary>
/// Species: Sphaenorhynchus lacteus
/// NCBI TaxId: 279984
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphaenorhynchus_lacteus : Sphaenorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphaenorhynchus lacteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphaenorhynchus_lacteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279984;
}
