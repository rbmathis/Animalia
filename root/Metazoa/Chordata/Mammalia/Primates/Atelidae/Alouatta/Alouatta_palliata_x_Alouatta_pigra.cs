namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta palliata x Alouatta pigra
/// NCBI TaxId: 2487933
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_palliata_x_Alouatta_pigra : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta palliata x Alouatta pigra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_palliata_x_Alouatta_pigra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2487933;
}
