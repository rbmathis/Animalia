using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Arius;

/// <summary>
/// Abstract class for Arius (genus).
/// NCBI TaxId: 75285
/// </summary>
public abstract class Arius : Ariidae, IArius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75285;

    /// <inheritdoc />
    public virtual string GenusName => "Arius";

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
