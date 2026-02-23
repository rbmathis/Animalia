namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus norvegicus
/// NCBI TaxId: 10116
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_norvegicus : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus norvegicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_norvegicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10116;
}
