namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae.Vidua;

/// <summary>
/// Species: Vidua chalybeata x Vidua paradisaea
/// NCBI TaxId: 251333
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vidua_chalybeata_x_Vidua_paradisaea : Vidua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vidua chalybeata x Vidua paradisaea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vidua_chalybeata_x_Vidua_paradisaea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 251333;
}
