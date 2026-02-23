namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Anarhynchus;

/// <summary>
/// Species: Anarhynchus javanicus
/// NCBI TaxId: 2126354
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anarhynchus_javanicus : Anarhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anarhynchus javanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anarhynchus_javanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2126354;
}
