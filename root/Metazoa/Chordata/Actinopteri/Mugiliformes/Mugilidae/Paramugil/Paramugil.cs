using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Paramugil;

/// <summary>
/// Abstract class for Paramugil (genus).
/// NCBI TaxId: 908968
/// </summary>
public abstract class Paramugil : Mugilidae, IParamugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 908968;

    /// <inheritdoc />
    public virtual string GenusName => "Paramugil";

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
