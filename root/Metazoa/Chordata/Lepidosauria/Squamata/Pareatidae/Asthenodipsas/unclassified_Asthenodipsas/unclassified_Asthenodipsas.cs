using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Asthenodipsas;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Asthenodipsas.unclassified_Asthenodipsas;

/// <summary>
/// Abstract class for unclassified Asthenodipsas (no rank).
/// NCBI TaxId: 2647577
/// </summary>
public abstract class unclassified_Asthenodipsas : Asthenodipsas, Iunclassified_Asthenodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Asthenodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647577;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Asthenodipsas";
}
