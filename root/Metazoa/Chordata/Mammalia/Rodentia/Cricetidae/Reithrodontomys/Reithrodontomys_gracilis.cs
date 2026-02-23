namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

/// <summary>
/// Species: Reithrodontomys gracilis
/// NCBI TaxId: 243215
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Reithrodontomys_gracilis : Reithrodontomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Reithrodontomys gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Reithrodontomys_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 243215;
}
