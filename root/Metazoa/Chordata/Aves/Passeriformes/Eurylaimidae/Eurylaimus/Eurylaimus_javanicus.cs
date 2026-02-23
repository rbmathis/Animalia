namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Eurylaimus;

/// <summary>
/// Species: Eurylaimus javanicus
/// NCBI TaxId: 363775
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eurylaimus_javanicus : Eurylaimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eurylaimus javanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eurylaimus_javanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 363775;
}
