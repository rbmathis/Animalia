namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Ornithorhynchidae.Ornithorhynchus;

/// <summary>
/// Species: Ornithorhynchus anatinus
/// NCBI TaxId: 9258
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ornithorhynchus_anatinus : Ornithorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ornithorhynchus anatinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ornithorhynchus_anatinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9258;
}
