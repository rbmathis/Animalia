namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Syrmaticus;

/// <summary>
/// Species: Syrmaticus soemmerringii
/// NCBI TaxId: 9067
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syrmaticus_soemmerringii : Syrmaticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syrmaticus soemmerringii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syrmaticus_soemmerringii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9067;
}
