using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parachaeturichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parachaeturichthys.unclassified_Parachaeturichthys;

/// <summary>
/// Abstract class for unclassified Parachaeturichthys (no rank).
/// NCBI TaxId: 2823258
/// </summary>
public abstract class unclassified_Parachaeturichthys : Parachaeturichthys, Iunclassified_Parachaeturichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parachaeturichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823258;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parachaeturichthys";
}
