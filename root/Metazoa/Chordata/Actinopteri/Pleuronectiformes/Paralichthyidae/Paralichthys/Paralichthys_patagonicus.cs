namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Paralichthys;

/// <summary>
/// Species: Paralichthys patagonicus
/// NCBI TaxId: 253862
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paralichthys_patagonicus : Paralichthys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paralichthys patagonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paralichthys_patagonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 253862;
}
