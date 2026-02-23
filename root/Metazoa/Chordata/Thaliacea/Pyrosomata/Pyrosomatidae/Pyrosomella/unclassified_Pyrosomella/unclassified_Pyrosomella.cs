using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrosomella;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrosomella.unclassified_Pyrosomella;

/// <summary>
/// Abstract class for unclassified Pyrosomella (no rank).
/// NCBI TaxId: 2783246
/// </summary>
public abstract class unclassified_Pyrosomella : Pyrosomella, Iunclassified_Pyrosomella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrosomella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2783246;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrosomella";
}
