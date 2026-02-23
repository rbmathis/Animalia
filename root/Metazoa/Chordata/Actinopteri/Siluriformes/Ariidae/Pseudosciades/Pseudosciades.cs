using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Pseudosciades;

/// <summary>
/// Abstract class for Pseudosciades (genus).
/// NCBI TaxId: 3363470
/// </summary>
public abstract class Pseudosciades : Ariidae, IPseudosciades
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudosciades";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363470;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudosciades";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
