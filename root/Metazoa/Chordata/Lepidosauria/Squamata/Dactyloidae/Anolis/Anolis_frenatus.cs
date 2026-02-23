namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis frenatus
/// NCBI TaxId: 323581
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_frenatus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis frenatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_frenatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323581;
}
