namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Species: Geomys lutescens x halli
/// NCBI TaxId: 504288
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geomys_lutescens_x_halli : Geomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geomys lutescens x halli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geomys_lutescens_x_halli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 504288;
}
