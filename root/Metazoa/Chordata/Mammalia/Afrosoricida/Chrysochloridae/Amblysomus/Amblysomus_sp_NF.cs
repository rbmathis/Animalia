namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Amblysomus;

/// <summary>
/// Species: Amblysomus sp. NF
/// NCBI TaxId: 1775245
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblysomus_sp_NF : Amblysomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblysomus sp. NF";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblysomus_sp_NF";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1775245;
}
