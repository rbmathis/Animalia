namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus indutus
/// NCBI TaxId: 273921
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_indutus : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus indutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_indutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 273921;
}
