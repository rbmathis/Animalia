namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Merops;

/// <summary>
/// Species: Merops americanus
/// NCBI TaxId: 3150142
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merops_americanus : Merops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merops americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merops_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150142;
}
