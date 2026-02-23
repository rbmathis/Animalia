using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Myoglanis;

/// <summary>
/// Abstract class for Myoglanis (genus).
/// NCBI TaxId: 1281319
/// </summary>
public abstract class Myoglanis : Heptapteridae, IMyoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1281319;

    /// <inheritdoc />
    public virtual string GenusName => "Myoglanis";

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
