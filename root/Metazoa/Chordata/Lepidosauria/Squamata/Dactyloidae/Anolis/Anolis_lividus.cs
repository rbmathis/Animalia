namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis lividus
/// NCBI TaxId: 145401
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_lividus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis lividus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_lividus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 145401;
}
