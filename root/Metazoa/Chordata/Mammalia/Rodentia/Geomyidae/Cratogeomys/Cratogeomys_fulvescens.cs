namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Cratogeomys;

/// <summary>
/// Species: Cratogeomys fulvescens
/// NCBI TaxId: 288025
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cratogeomys_fulvescens : Cratogeomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cratogeomys fulvescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cratogeomys_fulvescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 288025;
}
