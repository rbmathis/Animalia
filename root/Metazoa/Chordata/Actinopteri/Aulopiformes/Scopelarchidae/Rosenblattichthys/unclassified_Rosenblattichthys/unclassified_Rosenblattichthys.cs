using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Rosenblattichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Rosenblattichthys.unclassified_Rosenblattichthys;

/// <summary>
/// Abstract class for unclassified Rosenblattichthys (no rank).
/// NCBI TaxId: 2641588
/// </summary>
public abstract class unclassified_Rosenblattichthys : Rosenblattichthys, Iunclassified_Rosenblattichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rosenblattichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641588;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rosenblattichthys";
}
