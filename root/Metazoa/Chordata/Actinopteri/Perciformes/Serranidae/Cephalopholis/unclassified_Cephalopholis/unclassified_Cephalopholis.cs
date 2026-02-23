using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Cephalopholis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Cephalopholis.unclassified_Cephalopholis;

/// <summary>
/// Abstract class for unclassified Cephalopholis (no rank).
/// NCBI TaxId: 3157310
/// </summary>
public abstract class unclassified_Cephalopholis : Cephalopholis, Iunclassified_Cephalopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cephalopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3157310;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cephalopholis";
}
