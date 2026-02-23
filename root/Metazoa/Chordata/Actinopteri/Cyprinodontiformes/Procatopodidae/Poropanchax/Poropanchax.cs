using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Poropanchax;

/// <summary>
/// Abstract class for Poropanchax (genus).
/// NCBI TaxId: 1573815
/// </summary>
public abstract class Poropanchax : Procatopodidae, IPoropanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poropanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1573815;

    /// <inheritdoc />
    public virtual string GenusName => "Poropanchax";

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
