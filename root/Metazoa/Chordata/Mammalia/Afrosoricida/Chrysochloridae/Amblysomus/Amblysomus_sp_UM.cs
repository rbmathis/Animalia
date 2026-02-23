namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Amblysomus;

/// <summary>
/// Species: Amblysomus sp. UM
/// NCBI TaxId: 1775246
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblysomus_sp_UM : Amblysomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblysomus sp. UM";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblysomus_sp_UM";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1775246;
}
