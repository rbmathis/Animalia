namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta belzebul
/// NCBI TaxId: 30590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_belzebul : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta belzebul";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_belzebul";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30590;
}
