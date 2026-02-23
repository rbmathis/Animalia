namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Rhizomys;

/// <summary>
/// Species: Rhizomys sinensis
/// NCBI TaxId: 146130
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhizomys_sinensis : Rhizomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhizomys sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhizomys_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 146130;
}
