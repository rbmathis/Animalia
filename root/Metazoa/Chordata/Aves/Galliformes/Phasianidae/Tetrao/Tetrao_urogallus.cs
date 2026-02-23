namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetrao;

/// <summary>
/// Species: Tetrao urogallus
/// NCBI TaxId: 100830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tetrao_urogallus : Tetrao
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tetrao urogallus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tetrao_urogallus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100830;
}
