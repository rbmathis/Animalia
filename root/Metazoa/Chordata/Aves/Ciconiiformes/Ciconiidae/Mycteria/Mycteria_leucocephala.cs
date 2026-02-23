namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Mycteria;

/// <summary>
/// Species: Mycteria leucocephala
/// NCBI TaxId: 52781
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mycteria_leucocephala : Mycteria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mycteria leucocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mycteria_leucocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52781;
}
