namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Bucco;

/// <summary>
/// Species: Bucco macrodactylus
/// NCBI TaxId: 458186
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bucco_macrodactylus : Bucco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bucco macrodactylus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bucco_macrodactylus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458186;
}
