namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Muscicapa;

/// <summary>
/// Species: Muscicapa tyrrhenica
/// NCBI TaxId: 2819360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Muscicapa_tyrrhenica : Muscicapa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Muscicapa tyrrhenica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Muscicapa_tyrrhenica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2819360;
}
