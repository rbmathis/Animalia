using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Horaglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Horaglanis.unclassified_Horaglanis;

/// <summary>
/// Abstract class for unclassified Horaglanis (no rank).
/// NCBI TaxId: 2685605
/// </summary>
public abstract class unclassified_Horaglanis : Horaglanis, Iunclassified_Horaglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Horaglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685605;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Horaglanis";
}
