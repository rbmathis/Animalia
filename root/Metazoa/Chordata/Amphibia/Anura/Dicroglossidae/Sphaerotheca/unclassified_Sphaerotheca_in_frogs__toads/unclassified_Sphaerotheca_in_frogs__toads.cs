using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Sphaerotheca;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Sphaerotheca.unclassified_Sphaerotheca_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Sphaerotheca (in: frogs & toads) (no rank).
/// NCBI TaxId: 2688953
/// </summary>
public abstract class unclassified_Sphaerotheca_in_frogs__toads : Sphaerotheca, Iunclassified_Sphaerotheca_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphaerotheca (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688953;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphaerotheca_in_frogs__toads";
}
