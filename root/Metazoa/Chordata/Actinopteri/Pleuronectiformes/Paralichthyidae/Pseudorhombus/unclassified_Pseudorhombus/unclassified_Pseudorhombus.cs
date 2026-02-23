using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Pseudorhombus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Pseudorhombus.unclassified_Pseudorhombus;

/// <summary>
/// Abstract class for unclassified Pseudorhombus (no rank).
/// NCBI TaxId: 2640529
/// </summary>
public abstract class unclassified_Pseudorhombus : Pseudorhombus, Iunclassified_Pseudorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudorhombus";
}
