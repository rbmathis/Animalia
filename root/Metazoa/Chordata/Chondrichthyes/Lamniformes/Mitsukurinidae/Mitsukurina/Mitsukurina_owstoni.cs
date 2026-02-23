namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Mitsukurinidae.Mitsukurina;

/// <summary>
/// Species: Mitsukurina owstoni
/// NCBI TaxId: 57987
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mitsukurina_owstoni : Mitsukurina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mitsukurina owstoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mitsukurina_owstoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57987;
}
