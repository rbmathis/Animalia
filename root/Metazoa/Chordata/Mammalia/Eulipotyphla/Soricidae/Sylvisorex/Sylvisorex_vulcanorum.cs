namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sylvisorex;

/// <summary>
/// Species: Sylvisorex vulcanorum
/// NCBI TaxId: 350805
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvisorex_vulcanorum : Sylvisorex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvisorex vulcanorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvisorex_vulcanorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 350805;
}
