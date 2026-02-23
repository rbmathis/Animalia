namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae.Dinornis;

/// <summary>
/// Species: Dinornis giganteus
/// NCBI TaxId: 147464
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dinornis_giganteus : Dinornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dinornis giganteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dinornis_giganteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 147464;
}
