namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Pattonomys;

/// <summary>
/// Species: Pattonomys semivillosus
/// NCBI TaxId: 1567524
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pattonomys_semivillosus : Pattonomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pattonomys semivillosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pattonomys_semivillosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1567524;
}
