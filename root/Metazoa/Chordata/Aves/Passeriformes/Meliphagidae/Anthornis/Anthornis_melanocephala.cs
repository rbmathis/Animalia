namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Anthornis;

/// <summary>
/// Species: Anthornis melanocephala
/// NCBI TaxId: 1930942
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anthornis_melanocephala : Anthornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anthornis melanocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anthornis_melanocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1930942;
}
