using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lubricogobius;

/// <summary>
/// Abstract class for Lubricogobius (genus).
/// NCBI TaxId: 2873923
/// </summary>
public abstract class Lubricogobius : Gobiidae, ILubricogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lubricogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2873923;

    /// <inheritdoc />
    public virtual string GenusName => "Lubricogobius";

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
