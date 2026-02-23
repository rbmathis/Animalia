namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Burhinus;

/// <summary>
/// Species: Burhinus bistriatus
/// NCBI TaxId: 240201
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Burhinus_bistriatus : Burhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Burhinus bistriatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Burhinus_bistriatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 240201;
}
