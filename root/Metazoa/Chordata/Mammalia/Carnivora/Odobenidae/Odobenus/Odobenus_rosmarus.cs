namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Odobenidae.Odobenus;

/// <summary>
/// Species: Odobenus rosmarus
/// NCBI TaxId: 9707
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Odobenus_rosmarus : Odobenus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Odobenus rosmarus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Odobenus_rosmarus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9707;
}
