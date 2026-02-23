namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis cryptolimifrons
/// NCBI TaxId: 2126362
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_cryptolimifrons : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis cryptolimifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_cryptolimifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2126362;
}
