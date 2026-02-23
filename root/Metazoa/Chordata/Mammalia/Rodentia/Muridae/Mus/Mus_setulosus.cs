namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus setulosus
/// NCBI TaxId: 10102
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_setulosus : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus setulosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_setulosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10102;
}
