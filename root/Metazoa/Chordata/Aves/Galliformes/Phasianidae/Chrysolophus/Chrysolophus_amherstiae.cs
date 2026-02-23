namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Chrysolophus;

/// <summary>
/// Species: Chrysolophus amherstiae
/// NCBI TaxId: 9088
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chrysolophus_amherstiae : Chrysolophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chrysolophus amherstiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chrysolophus_amherstiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9088;
}
