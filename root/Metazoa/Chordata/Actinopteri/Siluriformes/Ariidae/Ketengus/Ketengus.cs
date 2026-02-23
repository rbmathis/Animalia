using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Ketengus;

/// <summary>
/// Abstract class for Ketengus (genus).
/// NCBI TaxId: 337776
/// </summary>
public abstract class Ketengus : Ariidae, IKetengus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ketengus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337776;

    /// <inheritdoc />
    public virtual string GenusName => "Ketengus";

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
