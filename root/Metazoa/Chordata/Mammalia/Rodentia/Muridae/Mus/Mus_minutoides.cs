namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus minutoides
/// NCBI TaxId: 10105
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_minutoides : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus minutoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_minutoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10105;
}
