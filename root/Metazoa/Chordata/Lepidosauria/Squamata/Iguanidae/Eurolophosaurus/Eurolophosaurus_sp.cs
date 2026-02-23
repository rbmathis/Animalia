namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Eurolophosaurus;

/// <summary>
/// Species: Eurolophosaurus sp.
/// NCBI TaxId: 2608666
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eurolophosaurus_sp : Eurolophosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eurolophosaurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eurolophosaurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2608666;
}
