namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis macrophallus
/// NCBI TaxId: 3145555
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_macrophallus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis macrophallus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_macrophallus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3145555;
}
