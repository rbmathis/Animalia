using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pseudamiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pseudamiops.unclassified_Pseudamiops;

/// <summary>
/// Abstract class for unclassified Pseudamiops (no rank).
/// NCBI TaxId: 2628265
/// </summary>
public abstract class unclassified_Pseudamiops : Pseudamiops, Iunclassified_Pseudamiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudamiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628265;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudamiops";
}
