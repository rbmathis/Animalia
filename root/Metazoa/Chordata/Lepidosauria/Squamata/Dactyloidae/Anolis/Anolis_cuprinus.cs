namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis cuprinus
/// NCBI TaxId: 1809420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_cuprinus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis cuprinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_cuprinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1809420;
}
