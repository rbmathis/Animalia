namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastacomys;

/// <summary>
/// Species: Mastacomys fuscus
/// NCBI TaxId: 337222
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mastacomys_fuscus : Mastacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mastacomys fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mastacomys_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 337222;
}
