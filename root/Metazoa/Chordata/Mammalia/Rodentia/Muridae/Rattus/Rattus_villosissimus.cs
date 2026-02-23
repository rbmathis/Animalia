namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus villosissimus
/// NCBI TaxId: 10122
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_villosissimus : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus villosissimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_villosissimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10122;
}
