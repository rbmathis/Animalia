namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Actinemys;

/// <summary>
/// Species: Actinemys pallida
/// NCBI TaxId: 1485138
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinemys_pallida : Actinemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinemys pallida";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinemys_pallida";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1485138;
}
