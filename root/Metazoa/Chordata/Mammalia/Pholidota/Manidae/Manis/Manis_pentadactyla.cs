namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

/// <summary>
/// Species: Manis pentadactyla
/// NCBI TaxId: 143292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manis_pentadactyla : Manis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manis pentadactyla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manis_pentadactyla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143292;
}
