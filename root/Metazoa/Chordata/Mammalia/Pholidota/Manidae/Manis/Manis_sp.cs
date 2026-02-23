namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

/// <summary>
/// Species: Manis sp.
/// NCBI TaxId: 49127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manis_sp : Manis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 49127;
}
