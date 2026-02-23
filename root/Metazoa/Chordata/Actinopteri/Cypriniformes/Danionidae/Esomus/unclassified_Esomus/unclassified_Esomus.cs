using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Esomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Esomus.unclassified_Esomus;

/// <summary>
/// Abstract class for unclassified Esomus (no rank).
/// NCBI TaxId: 2642133
/// </summary>
public abstract class unclassified_Esomus : Esomus, Iunclassified_Esomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Esomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642133;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Esomus";
}
