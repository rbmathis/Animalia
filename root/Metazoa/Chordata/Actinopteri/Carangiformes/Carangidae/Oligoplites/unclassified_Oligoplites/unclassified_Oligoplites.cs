using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Oligoplites;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Oligoplites.unclassified_Oligoplites;

/// <summary>
/// Abstract class for unclassified Oligoplites (no rank).
/// NCBI TaxId: 3410824
/// </summary>
public abstract class unclassified_Oligoplites : Oligoplites, Iunclassified_Oligoplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oligoplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3410824;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oligoplites";
}
