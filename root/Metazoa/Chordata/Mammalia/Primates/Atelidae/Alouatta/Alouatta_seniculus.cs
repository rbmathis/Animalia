namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta seniculus
/// NCBI TaxId: 9503
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_seniculus : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta seniculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_seniculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9503;
}
