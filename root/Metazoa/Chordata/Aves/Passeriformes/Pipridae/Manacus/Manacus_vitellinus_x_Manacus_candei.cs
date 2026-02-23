namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Manacus;

/// <summary>
/// Species: Manacus vitellinus x Manacus candei
/// NCBI TaxId: 2992770
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manacus_vitellinus_x_Manacus_candei : Manacus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manacus vitellinus x Manacus candei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manacus_vitellinus_x_Manacus_candei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2992770;
}
