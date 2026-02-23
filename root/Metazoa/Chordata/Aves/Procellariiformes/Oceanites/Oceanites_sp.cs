namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

/// <summary>
/// Species: Oceanites sp.
/// NCBI TaxId: 3342347
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oceanites_sp : Oceanites
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oceanites sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oceanites_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3342347;
}
