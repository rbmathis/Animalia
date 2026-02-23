namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Tachyphonus;

/// <summary>
/// Species: Tachyphonus rufus
/// NCBI TaxId: 555354
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachyphonus_rufus : Tachyphonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachyphonus rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachyphonus_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555354;
}
