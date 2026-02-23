using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Microglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Microglanis.unclassified_Microglanis;

/// <summary>
/// Abstract class for unclassified Microglanis (no rank).
/// NCBI TaxId: 2641790
/// </summary>
public abstract class unclassified_Microglanis : Microglanis, Iunclassified_Microglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641790;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microglanis";
}
