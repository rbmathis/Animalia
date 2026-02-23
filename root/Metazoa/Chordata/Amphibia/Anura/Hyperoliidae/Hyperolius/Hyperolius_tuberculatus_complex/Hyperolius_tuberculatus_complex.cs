using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius.Hyperolius_tuberculatus_complex;

/// <summary>
/// Abstract class for Hyperolius tuberculatus complex (no rank).
/// NCBI TaxId: 643477
/// </summary>
public abstract class Hyperolius_tuberculatus_complex : Hyperolius, IHyperolius_tuberculatus_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperolius tuberculatus complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643477;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Hyperolius_tuberculatus_complex";
}
