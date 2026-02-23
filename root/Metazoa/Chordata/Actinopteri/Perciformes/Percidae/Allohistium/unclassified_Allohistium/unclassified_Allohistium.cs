using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Allohistium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Allohistium.unclassified_Allohistium;

/// <summary>
/// Abstract class for unclassified Allohistium (no rank).
/// NCBI TaxId: 3385833
/// </summary>
public abstract class unclassified_Allohistium : Allohistium, Iunclassified_Allohistium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Allohistium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3385833;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Allohistium";
}
