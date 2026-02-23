namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Cylindraspis;

/// <summary>
/// Species: Cylindraspis inepta
/// NCBI TaxId: 180174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cylindraspis_inepta : Cylindraspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cylindraspis inepta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cylindraspis_inepta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 180174;
}
