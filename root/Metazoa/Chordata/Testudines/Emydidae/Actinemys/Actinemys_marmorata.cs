namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Actinemys;

/// <summary>
/// Species: Actinemys marmorata
/// NCBI TaxId: 335395
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinemys_marmorata : Actinemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinemys marmorata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinemys_marmorata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 335395;
}
