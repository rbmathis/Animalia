using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Psettina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Psettina.unclassified_Psettina;

/// <summary>
/// Abstract class for unclassified Psettina (no rank).
/// NCBI TaxId: 3049906
/// </summary>
public abstract class unclassified_Psettina : Psettina, Iunclassified_Psettina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psettina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049906;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psettina";
}
