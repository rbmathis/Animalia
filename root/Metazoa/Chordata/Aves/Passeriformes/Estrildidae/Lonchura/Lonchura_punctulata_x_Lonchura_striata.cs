namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Lonchura;

/// <summary>
/// Species: Lonchura punctulata x Lonchura striata
/// NCBI TaxId: 3383342
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lonchura_punctulata_x_Lonchura_striata : Lonchura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lonchura punctulata x Lonchura striata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lonchura_punctulata_x_Lonchura_striata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3383342;
}
