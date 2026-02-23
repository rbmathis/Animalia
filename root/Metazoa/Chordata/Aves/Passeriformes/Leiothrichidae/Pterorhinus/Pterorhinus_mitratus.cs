namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Pterorhinus;

/// <summary>
/// Species: Pterorhinus mitratus
/// NCBI TaxId: 3151027
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pterorhinus_mitratus : Pterorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pterorhinus mitratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pterorhinus_mitratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3151027;
}
