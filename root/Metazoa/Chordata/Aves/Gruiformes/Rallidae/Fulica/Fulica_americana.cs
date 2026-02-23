namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Fulica;

/// <summary>
/// Species: Fulica americana
/// NCBI TaxId: 81903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Fulica_americana : Fulica
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Fulica americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Fulica_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81903;
}
