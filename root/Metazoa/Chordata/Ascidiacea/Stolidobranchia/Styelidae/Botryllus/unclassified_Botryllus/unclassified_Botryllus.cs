using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botryllus;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botryllus.unclassified_Botryllus;

/// <summary>
/// Abstract class for unclassified Botryllus (no rank).
/// NCBI TaxId: 2619591
/// </summary>
public abstract class unclassified_Botryllus : Botryllus, Iunclassified_Botryllus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Botryllus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619591;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Botryllus";
}
