namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hapalomys;

/// <summary>
/// Species: Hapalomys longicaudatus
/// NCBI TaxId: 1542949
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalomys_longicaudatus : Hapalomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalomys longicaudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalomys_longicaudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1542949;
}
