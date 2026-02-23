namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys venustus
/// NCBI TaxId: 160456
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_venustus : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys venustus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_venustus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160456;
}
