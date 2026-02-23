using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Erythrinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Erythrinus.unclassified_Erythrinus;

/// <summary>
/// Abstract class for unclassified Erythrinus (no rank).
/// NCBI TaxId: 3101844
/// </summary>
public abstract class unclassified_Erythrinus : Erythrinus, Iunclassified_Erythrinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erythrinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101844;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erythrinus";
}
