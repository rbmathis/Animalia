namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Casuariidae.Casuarius;

/// <summary>
/// Species: Casuarius sp.
/// NCBI TaxId: 1740870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Casuarius_sp : Casuarius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Casuarius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Casuarius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1740870;
}
