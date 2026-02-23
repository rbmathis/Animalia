using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Benthalbella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Benthalbella.unclassified_Benthalbella;

/// <summary>
/// Abstract class for unclassified Benthalbella (no rank).
/// NCBI TaxId: 2646539
/// </summary>
public abstract class unclassified_Benthalbella : Benthalbella, Iunclassified_Benthalbella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Benthalbella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646539;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Benthalbella";
}
