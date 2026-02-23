using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Geophagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Geophagus.unclassified_Geophagus;

/// <summary>
/// Abstract class for unclassified Geophagus (no rank).
/// NCBI TaxId: 2646258
/// </summary>
public abstract class unclassified_Geophagus : Geophagus, Iunclassified_Geophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646258;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geophagus";
}
