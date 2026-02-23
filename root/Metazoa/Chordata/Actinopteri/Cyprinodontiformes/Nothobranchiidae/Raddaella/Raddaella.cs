using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Raddaella;

/// <summary>
/// Abstract class for Raddaella (genus).
/// NCBI TaxId: 3034823
/// </summary>
public abstract class Raddaella : Nothobranchiidae, IRaddaella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raddaella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3034823;

    /// <inheritdoc />
    public virtual string GenusName => "Raddaella";

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
