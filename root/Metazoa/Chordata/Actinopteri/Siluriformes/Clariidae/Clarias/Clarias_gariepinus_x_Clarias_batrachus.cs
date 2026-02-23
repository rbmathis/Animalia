namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Species: Clarias gariepinus x Clarias batrachus
/// NCBI TaxId: 1630651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clarias_gariepinus_x_Clarias_batrachus : Clarias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clarias gariepinus x Clarias batrachus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clarias_gariepinus_x_Clarias_batrachus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1630651;
}
