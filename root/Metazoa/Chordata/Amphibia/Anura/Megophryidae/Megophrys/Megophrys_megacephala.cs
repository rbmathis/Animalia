namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys;

/// <summary>
/// Species: Megophrys megacephala
/// NCBI TaxId: 1960341
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megophrys_megacephala : Megophrys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megophrys megacephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megophrys_megacephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1960341;
}
