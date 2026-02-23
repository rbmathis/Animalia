using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrosoma.unclassified_Pyrosoma;

/// <summary>
/// Abstract class for unclassified Pyrosoma (no rank).
/// NCBI TaxId: 3065357
/// </summary>
public abstract class unclassified_Pyrosoma : Pyrosoma, Iunclassified_Pyrosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3065357;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrosoma";
}
