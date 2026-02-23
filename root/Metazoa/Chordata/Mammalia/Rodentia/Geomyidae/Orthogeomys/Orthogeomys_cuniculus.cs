namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Orthogeomys;

/// <summary>
/// Species: Orthogeomys cuniculus
/// NCBI TaxId: 1827141
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Orthogeomys_cuniculus : Orthogeomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Orthogeomys cuniculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Orthogeomys_cuniculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1827141;
}
