namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireolanius;

/// <summary>
/// Species: Vireolanius pulchellus
/// NCBI TaxId: 1540928
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireolanius_pulchellus : Vireolanius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireolanius pulchellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireolanius_pulchellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1540928;
}
