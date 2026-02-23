namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis pseudopachypus
/// NCBI TaxId: 1638964
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_pseudopachypus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis pseudopachypus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_pseudopachypus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1638964;
}
