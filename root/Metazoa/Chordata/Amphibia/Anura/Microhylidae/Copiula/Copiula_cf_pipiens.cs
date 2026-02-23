namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Copiula;

/// <summary>
/// Species: Copiula cf. pipiens
/// NCBI TaxId: 3345268
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Copiula_cf_pipiens : Copiula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Copiula cf. pipiens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Copiula_cf_pipiens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3345268;
}
