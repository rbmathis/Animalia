using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Leptocypris;

/// <summary>
/// Abstract class for Leptocypris (genus).
/// NCBI TaxId: 643463
/// </summary>
public abstract class Leptocypris : Danionidae, ILeptocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643463;

    /// <inheritdoc />
    public virtual string GenusName => "Leptocypris";

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
