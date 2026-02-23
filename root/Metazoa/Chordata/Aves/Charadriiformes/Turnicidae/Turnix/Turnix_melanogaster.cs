namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Turnicidae.Turnix;

/// <summary>
/// Species: Turnix melanogaster
/// NCBI TaxId: 3121210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turnix_melanogaster : Turnix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turnix melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turnix_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3121210;
}
