using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Scaphirhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Scaphirhynchus.unclassified_Scaphirhynchus;

/// <summary>
/// Abstract class for unclassified Scaphirhynchus (no rank).
/// NCBI TaxId: 2643421
/// </summary>
public abstract class unclassified_Scaphirhynchus : Scaphirhynchus, Iunclassified_Scaphirhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scaphirhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scaphirhynchus";
}
