namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiops;

/// <summary>
/// Species: Tamiops rodolphii
/// NCBI TaxId: 1048688
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamiops_rodolphii : Tamiops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamiops rodolphii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamiops_rodolphii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1048688;
}
