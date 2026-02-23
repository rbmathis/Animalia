using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Lepidorhombus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Lepidorhombus.unclassified_Lepidorhombus;

/// <summary>
/// Abstract class for unclassified Lepidorhombus (no rank).
/// NCBI TaxId: 2747770
/// </summary>
public abstract class unclassified_Lepidorhombus : Lepidorhombus, Iunclassified_Lepidorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2747770;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidorhombus";
}
