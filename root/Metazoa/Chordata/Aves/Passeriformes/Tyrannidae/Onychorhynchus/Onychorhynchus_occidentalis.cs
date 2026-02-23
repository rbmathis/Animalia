namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Onychorhynchus;

/// <summary>
/// Species: Onychorhynchus occidentalis
/// NCBI TaxId: 495165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Onychorhynchus_occidentalis : Onychorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Onychorhynchus occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Onychorhynchus_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 495165;
}
