using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Acaronia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Acaronia.unclassified_Acaronia;

/// <summary>
/// Abstract class for unclassified Acaronia (no rank).
/// NCBI TaxId: 2647971
/// </summary>
public abstract class unclassified_Acaronia : Acaronia, Iunclassified_Acaronia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acaronia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647971;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acaronia";
}
