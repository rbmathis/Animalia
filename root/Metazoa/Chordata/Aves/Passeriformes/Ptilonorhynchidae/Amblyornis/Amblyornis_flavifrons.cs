namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Amblyornis;

/// <summary>
/// Species: Amblyornis flavifrons
/// NCBI TaxId: 2699201
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amblyornis_flavifrons : Amblyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amblyornis flavifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amblyornis_flavifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2699201;
}
