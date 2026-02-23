namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Melanotis;

/// <summary>
/// Species: Melanotis caerulescens
/// NCBI TaxId: 111993
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melanotis_caerulescens : Melanotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melanotis caerulescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melanotis_caerulescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111993;
}
