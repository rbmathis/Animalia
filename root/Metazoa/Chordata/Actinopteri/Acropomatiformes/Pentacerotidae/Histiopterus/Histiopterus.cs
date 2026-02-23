using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Histiopterus;

/// <summary>
/// Abstract class for Histiopterus (genus).
/// NCBI TaxId: 270563
/// </summary>
public abstract class Histiopterus : Pentacerotidae, IHistiopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histiopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270563;

    /// <inheritdoc />
    public virtual string GenusName => "Histiopterus";

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
