namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer rutilans
/// NCBI TaxId: 150918
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_rutilans : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer rutilans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_rutilans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150918;
}
