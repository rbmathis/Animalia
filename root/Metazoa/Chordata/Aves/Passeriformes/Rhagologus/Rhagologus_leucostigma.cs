namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhagologus;

/// <summary>
/// Species: Rhagologus leucostigma
/// NCBI TaxId: 156170
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhagologus_leucostigma : Rhagologus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhagologus leucostigma";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhagologus_leucostigma";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 156170;
}
