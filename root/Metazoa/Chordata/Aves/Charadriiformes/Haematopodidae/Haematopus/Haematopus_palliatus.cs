namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Haematopodidae.Haematopus;

/// <summary>
/// Species: Haematopus palliatus
/// NCBI TaxId: 279960
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Haematopus_palliatus : Haematopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Haematopus palliatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Haematopus_palliatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279960;
}
