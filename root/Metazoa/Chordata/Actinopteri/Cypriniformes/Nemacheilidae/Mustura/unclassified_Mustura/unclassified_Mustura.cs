using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Mustura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Mustura.unclassified_Mustura;

/// <summary>
/// Abstract class for unclassified Mustura (no rank).
/// NCBI TaxId: 3119476
/// </summary>
public abstract class unclassified_Mustura : Mustura, Iunclassified_Mustura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mustura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3119476;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mustura";
}
