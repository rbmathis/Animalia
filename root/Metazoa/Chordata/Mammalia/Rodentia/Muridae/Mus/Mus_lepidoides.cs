namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus lepidoides
/// NCBI TaxId: 390847
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_lepidoides : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus lepidoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_lepidoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 390847;
}
