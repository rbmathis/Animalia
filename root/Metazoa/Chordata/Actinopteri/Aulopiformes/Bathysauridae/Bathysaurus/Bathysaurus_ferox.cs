namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauridae.Bathysaurus;

/// <summary>
/// Species: Bathysaurus ferox
/// NCBI TaxId: 172134
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bathysaurus_ferox : Bathysaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bathysaurus ferox";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bathysaurus_ferox";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172134;
}
