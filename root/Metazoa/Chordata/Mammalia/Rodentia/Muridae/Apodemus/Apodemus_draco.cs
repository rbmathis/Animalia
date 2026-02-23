namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus draco
/// NCBI TaxId: 129247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_draco : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus draco";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_draco";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129247;
}
