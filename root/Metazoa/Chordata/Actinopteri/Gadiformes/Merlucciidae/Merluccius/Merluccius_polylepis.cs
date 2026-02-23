namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

/// <summary>
/// Species: Merluccius polylepis
/// NCBI TaxId: 2705414
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merluccius_polylepis : Merluccius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merluccius polylepis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merluccius_polylepis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2705414;
}
