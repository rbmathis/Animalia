namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus terricolor
/// NCBI TaxId: 254704
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_terricolor : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus terricolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_terricolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 254704;
}
