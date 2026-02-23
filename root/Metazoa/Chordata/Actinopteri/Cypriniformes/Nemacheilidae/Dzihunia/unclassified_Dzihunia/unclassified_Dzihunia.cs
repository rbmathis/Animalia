using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Dzihunia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Dzihunia.unclassified_Dzihunia;

/// <summary>
/// Abstract class for unclassified Dzihunia (no rank).
/// NCBI TaxId: 2814144
/// </summary>
public abstract class unclassified_Dzihunia : Dzihunia, Iunclassified_Dzihunia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dzihunia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2814144;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dzihunia";
}
