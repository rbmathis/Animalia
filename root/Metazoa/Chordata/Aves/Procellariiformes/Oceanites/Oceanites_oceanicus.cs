namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

/// <summary>
/// Species: Oceanites oceanicus
/// NCBI TaxId: 79653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oceanites_oceanicus : Oceanites
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oceanites oceanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oceanites_oceanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79653;
}
