namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Mimus;

/// <summary>
/// Species: Mimus dorsalis
/// NCBI TaxId: 555274
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mimus_dorsalis : Mimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mimus dorsalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mimus_dorsalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555274;
}
