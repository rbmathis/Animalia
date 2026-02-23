using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Cyclothone;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Cyclothone.unclassified_Cyclothone;

/// <summary>
/// Abstract class for unclassified Cyclothone (no rank).
/// NCBI TaxId: 2629542
/// </summary>
public abstract class unclassified_Cyclothone : Cyclothone, Iunclassified_Cyclothone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyclothone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629542;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyclothone";
}
