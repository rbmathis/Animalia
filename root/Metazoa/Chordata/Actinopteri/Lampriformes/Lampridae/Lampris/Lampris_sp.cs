namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lampridae.Lampris;

/// <summary>
/// Species: Lampris sp.
/// NCBI TaxId: 94303
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lampris_sp : Lampris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lampris sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lampris_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94303;
}
