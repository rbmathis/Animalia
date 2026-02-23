namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Aepyornis;

/// <summary>
/// Species: Aepyornis sp.
/// NCBI TaxId: 1954183
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aepyornis_sp : Aepyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aepyornis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aepyornis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1954183;
}
