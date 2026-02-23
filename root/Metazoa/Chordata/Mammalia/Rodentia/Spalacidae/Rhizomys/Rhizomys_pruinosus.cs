namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Rhizomys;

/// <summary>
/// Species: Rhizomys pruinosus
/// NCBI TaxId: 53275
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhizomys_pruinosus : Rhizomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhizomys pruinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhizomys_pruinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 53275;
}
