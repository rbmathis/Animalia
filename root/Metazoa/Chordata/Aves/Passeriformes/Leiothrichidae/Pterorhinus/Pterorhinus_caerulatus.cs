namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Pterorhinus;

/// <summary>
/// Species: Pterorhinus caerulatus
/// NCBI TaxId: 3151018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pterorhinus_caerulatus : Pterorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pterorhinus caerulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pterorhinus_caerulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3151018;
}
