using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconacidnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconacidnus.unclassified_Bryconacidnus;

/// <summary>
/// Abstract class for unclassified Bryconacidnus (no rank).
/// NCBI TaxId: 2632380
/// </summary>
public abstract class unclassified_Bryconacidnus : Bryconacidnus, Iunclassified_Bryconacidnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryconacidnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632380;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryconacidnus";
}
