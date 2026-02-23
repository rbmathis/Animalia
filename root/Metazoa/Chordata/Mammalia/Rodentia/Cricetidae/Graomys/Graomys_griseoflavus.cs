namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Graomys;

/// <summary>
/// Species: Graomys griseoflavus
/// NCBI TaxId: 118865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graomys_griseoflavus : Graomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graomys griseoflavus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graomys_griseoflavus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 118865;
}
