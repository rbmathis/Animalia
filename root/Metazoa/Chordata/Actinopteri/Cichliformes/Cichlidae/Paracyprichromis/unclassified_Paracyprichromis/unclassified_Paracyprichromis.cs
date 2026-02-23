using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paracyprichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paracyprichromis.unclassified_Paracyprichromis;

/// <summary>
/// Abstract class for unclassified Paracyprichromis (no rank).
/// NCBI TaxId: 2630136
/// </summary>
public abstract class unclassified_Paracyprichromis : Paracyprichromis, Iunclassified_Paracyprichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracyprichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracyprichromis";
}
