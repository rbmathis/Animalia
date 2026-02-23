namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallus;

/// <summary>
/// Species: Rallus caerulescens
/// NCBI TaxId: 1294534
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rallus_caerulescens : Rallus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rallus caerulescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rallus_caerulescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1294534;
}
