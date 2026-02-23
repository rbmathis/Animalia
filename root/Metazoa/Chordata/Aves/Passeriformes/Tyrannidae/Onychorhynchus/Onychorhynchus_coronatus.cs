namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Onychorhynchus;

/// <summary>
/// Species: Onychorhynchus coronatus
/// NCBI TaxId: 360224
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Onychorhynchus_coronatus : Onychorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Onychorhynchus coronatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Onychorhynchus_coronatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 360224;
}
