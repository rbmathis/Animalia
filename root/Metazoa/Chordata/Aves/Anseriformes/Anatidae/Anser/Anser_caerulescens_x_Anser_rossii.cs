namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser caerulescens x Anser rossii
/// NCBI TaxId: 3420330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_caerulescens_x_Anser_rossii : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser caerulescens x Anser rossii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_caerulescens_x_Anser_rossii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3420330;
}
