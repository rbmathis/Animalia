using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Odontostoechus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Odontostoechus.unclassified_Odontostoechus;

/// <summary>
/// Abstract class for unclassified Odontostoechus (no rank).
/// NCBI TaxId: 2643183
/// </summary>
public abstract class unclassified_Odontostoechus : Odontostoechus, Iunclassified_Odontostoechus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontostoechus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontostoechus";
}
