using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gehyra;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gehyra.unclassified_Gehyra;

/// <summary>
/// Abstract class for unclassified Gehyra (no rank).
/// NCBI TaxId: 2637251
/// </summary>
public abstract class unclassified_Gehyra : Gehyra, Iunclassified_Gehyra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gehyra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637251;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gehyra";
}
