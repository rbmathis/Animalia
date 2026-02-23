using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Elates;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Elates.unclassified_Elates;

/// <summary>
/// Abstract class for unclassified Elates (no rank).
/// NCBI TaxId: 3538173
/// </summary>
public abstract class unclassified_Elates : Elates, Iunclassified_Elates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3538173;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elates";
}
