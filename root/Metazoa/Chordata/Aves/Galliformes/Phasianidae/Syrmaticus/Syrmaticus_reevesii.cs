namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Syrmaticus;

/// <summary>
/// Species: Syrmaticus reevesii
/// NCBI TaxId: 9066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syrmaticus_reevesii : Syrmaticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syrmaticus reevesii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syrmaticus_reevesii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9066;
}
