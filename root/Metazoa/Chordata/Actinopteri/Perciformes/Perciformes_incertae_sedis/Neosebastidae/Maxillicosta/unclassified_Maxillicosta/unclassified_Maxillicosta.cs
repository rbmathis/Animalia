using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Neosebastidae.Maxillicosta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Neosebastidae.Maxillicosta.unclassified_Maxillicosta;

/// <summary>
/// Abstract class for unclassified Maxillicosta (no rank).
/// NCBI TaxId: 2648307
/// </summary>
public abstract class unclassified_Maxillicosta : Maxillicosta, Iunclassified_Maxillicosta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Maxillicosta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648307;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Maxillicosta";
}
