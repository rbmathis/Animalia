namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser anser domesticus x Anser cygnoides domesticus
/// NCBI TaxId: 2741460
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_anser_domesticus_x_Anser_cygnoides_domesticus : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser anser domesticus x Anser cygnoides domesticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_anser_domesticus_x_Anser_cygnoides_domesticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2741460;
}
