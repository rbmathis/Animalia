namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufotes;

/// <summary>
/// Species: Bufotes siculus x Bufotes balearicus
/// NCBI TaxId: 870897
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufotes_siculus_x_Bufotes_balearicus : Bufotes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufotes siculus x Bufotes balearicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufotes_siculus_x_Bufotes_balearicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 870897;
}
