using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Lefua;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Lefua.unclassified_Lefua;

/// <summary>
/// Abstract class for unclassified Lefua (no rank).
/// NCBI TaxId: 2639554
/// </summary>
public abstract class unclassified_Lefua : Lefua, Iunclassified_Lefua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lefua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639554;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lefua";
}
