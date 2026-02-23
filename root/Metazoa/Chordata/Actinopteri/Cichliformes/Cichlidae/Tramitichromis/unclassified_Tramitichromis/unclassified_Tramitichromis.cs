using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tramitichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tramitichromis.unclassified_Tramitichromis;

/// <summary>
/// Abstract class for unclassified Tramitichromis (no rank).
/// NCBI TaxId: 2637955
/// </summary>
public abstract class unclassified_Tramitichromis : Tramitichromis, Iunclassified_Tramitichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tramitichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tramitichromis";
}
