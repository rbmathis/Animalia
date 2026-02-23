using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Chiloglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Chiloglanis.unclassified_Chiloglanis;

/// <summary>
/// Abstract class for unclassified Chiloglanis (no rank).
/// NCBI TaxId: 2647434
/// </summary>
public abstract class unclassified_Chiloglanis : Chiloglanis, Iunclassified_Chiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiloglanis";
}
