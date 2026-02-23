namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Plecotus;

/// <summary>
/// Species: Plecotus austriacus
/// NCBI TaxId: 109483
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plecotus_austriacus : Plecotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plecotus austriacus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plecotus_austriacus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109483;
}
