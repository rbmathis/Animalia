namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Amblysomus;

/// <summary>
/// Species: Amblysomus hottentotus
/// NCBI TaxId: 9391
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblysomus_hottentotus : Amblysomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblysomus hottentotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblysomus_hottentotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9391;
}
