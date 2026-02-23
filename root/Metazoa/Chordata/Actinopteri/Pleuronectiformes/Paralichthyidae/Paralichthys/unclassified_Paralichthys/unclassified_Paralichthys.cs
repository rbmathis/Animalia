using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Paralichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Paralichthys.unclassified_Paralichthys;

/// <summary>
/// Abstract class for unclassified Paralichthys (no rank).
/// NCBI TaxId: 3049925
/// </summary>
public abstract class unclassified_Paralichthys : Paralichthys, Iunclassified_Paralichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralichthys";
}
