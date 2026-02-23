using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.unclassified_Aploactinidae;

/// <summary>
/// Abstract class for unclassified Aploactinidae (no rank).
/// NCBI TaxId: 2580832
/// </summary>
public abstract class unclassified_Aploactinidae : Aploactinidae, Iunclassified_Aploactinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aploactinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2580832;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aploactinidae";
}
