using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Acentronichthys;

/// <summary>
/// Abstract class for Acentronichthys (genus).
/// NCBI TaxId: 1281315
/// </summary>
public abstract class Acentronichthys : Heptapteridae, IAcentronichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acentronichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1281315;

    /// <inheritdoc />
    public virtual string GenusName => "Acentronichthys";

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
