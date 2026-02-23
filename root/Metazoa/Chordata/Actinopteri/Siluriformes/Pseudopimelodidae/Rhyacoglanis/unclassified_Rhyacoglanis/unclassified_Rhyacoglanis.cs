using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Rhyacoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Rhyacoglanis.unclassified_Rhyacoglanis;

/// <summary>
/// Abstract class for unclassified Rhyacoglanis (no rank).
/// NCBI TaxId: 2830792
/// </summary>
public abstract class unclassified_Rhyacoglanis : Rhyacoglanis, Iunclassified_Rhyacoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhyacoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2830792;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhyacoglanis";
}
