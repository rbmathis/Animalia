namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Bibimys;

/// <summary>
/// Species: Bibimys labiosus
/// NCBI TaxId: 241102
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bibimys_labiosus : Bibimys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bibimys labiosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bibimys_labiosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241102;
}
