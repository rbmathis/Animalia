namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Petromyzon;

/// <summary>
/// Species: Petromyzon marinus
/// NCBI TaxId: 7757
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petromyzon_marinus : Petromyzon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petromyzon marinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petromyzon_marinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7757;
}
