namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Pitta;

/// <summary>
/// Species: Pitta novaeguineae
/// NCBI TaxId: 3150341
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pitta_novaeguineae : Pitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pitta novaeguineae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pitta_novaeguineae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150341;
}
