namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saimiri;

/// <summary>
/// Species: Saimiri ustus
/// NCBI TaxId: 66265
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saimiri_ustus : Saimiri
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saimiri ustus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saimiri_ustus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66265;
}
