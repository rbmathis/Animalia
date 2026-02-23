namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Tinamotis;

/// <summary>
/// Species: Tinamotis pentlandii
/// NCBI TaxId: 555361
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tinamotis_pentlandii : Tinamotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tinamotis pentlandii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tinamotis_pentlandii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555361;
}
