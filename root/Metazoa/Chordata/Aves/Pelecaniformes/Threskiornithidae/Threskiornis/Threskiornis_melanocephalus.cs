namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Threskiornis;

/// <summary>
/// Species: Threskiornis melanocephalus
/// NCBI TaxId: 425371
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Threskiornis_melanocephalus : Threskiornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Threskiornis melanocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Threskiornis_melanocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 425371;
}
