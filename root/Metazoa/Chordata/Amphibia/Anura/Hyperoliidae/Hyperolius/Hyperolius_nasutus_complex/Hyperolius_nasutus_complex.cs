using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Hyperolius.Hyperolius_nasutus_complex;

/// <summary>
/// Abstract class for Hyperolius nasutus complex (no rank).
/// NCBI TaxId: 643474
/// </summary>
public abstract class Hyperolius_nasutus_complex : Hyperolius, IHyperolius_nasutus_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperolius nasutus complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643474;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Hyperolius_nasutus_complex";
}
