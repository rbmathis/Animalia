namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corcoracidae.Corcorax;

/// <summary>
/// Species: Corcorax melanorhamphos
/// NCBI TaxId: 9145
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corcorax_melanorhamphos : Corcorax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corcorax melanorhamphos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corcorax_melanorhamphos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9145;
}
