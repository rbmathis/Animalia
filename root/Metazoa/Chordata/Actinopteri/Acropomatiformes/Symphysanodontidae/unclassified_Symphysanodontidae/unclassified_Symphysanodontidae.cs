using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae.unclassified_Symphysanodontidae;

/// <summary>
/// Abstract class for unclassified Symphysanodontidae (no rank).
/// NCBI TaxId: 3142538
/// </summary>
public abstract class unclassified_Symphysanodontidae : Symphysanodontidae, Iunclassified_Symphysanodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Symphysanodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3142538;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Symphysanodontidae";
}
