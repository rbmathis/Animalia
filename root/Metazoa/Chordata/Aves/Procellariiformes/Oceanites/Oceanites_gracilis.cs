namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

/// <summary>
/// Species: Oceanites gracilis
/// NCBI TaxId: 1112028
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oceanites_gracilis : Oceanites
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oceanites gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oceanites_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1112028;
}
