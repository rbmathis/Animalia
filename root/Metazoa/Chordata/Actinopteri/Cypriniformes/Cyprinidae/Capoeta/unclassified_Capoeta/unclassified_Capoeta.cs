using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Capoeta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Capoeta.unclassified_Capoeta;

/// <summary>
/// Abstract class for unclassified Capoeta (no rank).
/// NCBI TaxId: 2644880
/// </summary>
public abstract class unclassified_Capoeta : Capoeta, Iunclassified_Capoeta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Capoeta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644880;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Capoeta";
}
