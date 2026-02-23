namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Semnornis;

/// <summary>
/// Species: Semnornis ramphastinus
/// NCBI TaxId: 91785
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Semnornis_ramphastinus : Semnornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Semnornis ramphastinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Semnornis_ramphastinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 91785;
}
