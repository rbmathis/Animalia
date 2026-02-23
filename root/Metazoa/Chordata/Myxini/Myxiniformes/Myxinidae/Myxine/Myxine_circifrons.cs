namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Myxine;

/// <summary>
/// Species: Myxine circifrons
/// NCBI TaxId: 179978
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myxine_circifrons : Myxine
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myxine circifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myxine_circifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 179978;
}
