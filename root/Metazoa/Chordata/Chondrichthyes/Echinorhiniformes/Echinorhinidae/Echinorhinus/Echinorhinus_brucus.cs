namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae.Echinorhinus;

/// <summary>
/// Species: Echinorhinus brucus
/// NCBI TaxId: 862826
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Echinorhinus_brucus : Echinorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Echinorhinus brucus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Echinorhinus_brucus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 862826;
}
