using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Rhencus;

/// <summary>
/// Abstract class for Rhencus (genus).
/// NCBI TaxId: 2070548
/// </summary>
public abstract class Rhencus : Haemulidae, IRhencus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhencus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2070548;

    /// <inheritdoc />
    public virtual string GenusName => "Rhencus";

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
