namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

/// <summary>
/// Species: Charadrius vociferus
/// NCBI TaxId: 50402
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Charadrius_vociferus : Charadrius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Charadrius vociferus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Charadrius_vociferus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50402;
}
