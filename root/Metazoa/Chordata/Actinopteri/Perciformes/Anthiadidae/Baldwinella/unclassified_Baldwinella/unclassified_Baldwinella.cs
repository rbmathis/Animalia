using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Baldwinella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Baldwinella.unclassified_Baldwinella;

/// <summary>
/// Abstract class for unclassified Baldwinella (no rank).
/// NCBI TaxId: 2890350
/// </summary>
public abstract class unclassified_Baldwinella : Baldwinella, Iunclassified_Baldwinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Baldwinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890350;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Baldwinella";
}
