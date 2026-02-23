namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela nudipes
/// NCBI TaxId: 415383
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_nudipes : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela nudipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_nudipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 415383;
}
