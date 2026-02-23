namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Pelagodroma;

/// <summary>
/// Species: Pelagodroma marina
/// NCBI TaxId: 37075
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelagodroma_marina : Pelagodroma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelagodroma marina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelagodroma_marina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37075;
}
