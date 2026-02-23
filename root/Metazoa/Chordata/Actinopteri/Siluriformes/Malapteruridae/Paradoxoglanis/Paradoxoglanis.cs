using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae.Paradoxoglanis;

/// <summary>
/// Abstract class for Paradoxoglanis (genus).
/// NCBI TaxId: 1109122
/// </summary>
public abstract class Paradoxoglanis : Malapteruridae, IParadoxoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradoxoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109122;

    /// <inheritdoc />
    public virtual string GenusName => "Paradoxoglanis";

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
