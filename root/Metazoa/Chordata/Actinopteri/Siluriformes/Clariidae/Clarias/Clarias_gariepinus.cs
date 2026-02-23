namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias gariepinus
/// NCBI TaxId: 13013
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_gariepinus : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias gariepinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_gariepinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13013;
}
