using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Systomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Systomus.unclassified_Systomus;

/// <summary>
/// Abstract class for unclassified Systomus (no rank).
/// NCBI TaxId: 2639952
/// </summary>
public abstract class unclassified_Systomus : Systomus, Iunclassified_Systomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Systomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639952;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Systomus";
}
