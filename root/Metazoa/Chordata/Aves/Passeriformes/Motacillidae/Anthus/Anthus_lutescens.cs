namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus;

/// <summary>
/// Species: Anthus lutescens
/// NCBI TaxId: 555221
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anthus_lutescens : Anthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anthus lutescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anthus_lutescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555221;
}
