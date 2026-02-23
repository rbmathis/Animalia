namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus poliocephalus
/// NCBI TaxId: 358072
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_poliocephalus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus poliocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_poliocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 358072;
}
