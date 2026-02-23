namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chersina;

/// <summary>
/// Species: Chersina angulata
/// NCBI TaxId: 286001
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chersina_angulata : Chersina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chersina angulata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chersina_angulata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286001;
}
