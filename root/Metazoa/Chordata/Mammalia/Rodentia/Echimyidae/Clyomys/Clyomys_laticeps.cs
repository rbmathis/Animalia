namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Clyomys;

/// <summary>
/// Species: Clyomys laticeps
/// NCBI TaxId: 176498
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clyomys_laticeps : Clyomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clyomys laticeps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clyomys_laticeps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176498;
}
