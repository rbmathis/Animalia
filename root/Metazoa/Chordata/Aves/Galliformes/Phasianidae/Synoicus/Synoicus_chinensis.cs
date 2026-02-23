namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Synoicus;

/// <summary>
/// Species: Synoicus chinensis
/// NCBI TaxId: 3150611
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Synoicus_chinensis : Synoicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Synoicus chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Synoicus_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150611;
}
