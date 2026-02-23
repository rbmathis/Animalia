namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys erythroleucus
/// NCBI TaxId: 34849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_erythroleucus : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys erythroleucus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_erythroleucus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34849;
}
