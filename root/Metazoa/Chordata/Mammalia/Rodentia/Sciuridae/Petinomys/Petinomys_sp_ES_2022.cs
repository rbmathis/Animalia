namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petinomys;

/// <summary>
/// Species: Petinomys sp. ES-2022
/// NCBI TaxId: 2995525
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petinomys_sp_ES_2022 : Petinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petinomys sp. ES-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petinomys_sp_ES_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2995525;
}
