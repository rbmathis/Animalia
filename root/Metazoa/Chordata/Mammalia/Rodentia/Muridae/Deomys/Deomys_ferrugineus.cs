namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Deomys;

/// <summary>
/// Species: Deomys ferrugineus
/// NCBI TaxId: 106343
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Deomys_ferrugineus : Deomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Deomys ferrugineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Deomys_ferrugineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 106343;
}
