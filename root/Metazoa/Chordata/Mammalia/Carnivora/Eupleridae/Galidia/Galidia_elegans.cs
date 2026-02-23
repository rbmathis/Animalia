namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Galidia;

/// <summary>
/// Species: Galidia elegans
/// NCBI TaxId: 61400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galidia_elegans : Galidia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galidia elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galidia_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61400;
}
