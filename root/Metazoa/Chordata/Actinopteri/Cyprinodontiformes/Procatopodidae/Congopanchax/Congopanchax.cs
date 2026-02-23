using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Congopanchax;

/// <summary>
/// Abstract class for Congopanchax (genus).
/// NCBI TaxId: 1676982
/// </summary>
public abstract class Congopanchax : Procatopodidae, ICongopanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congopanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1676982;

    /// <inheritdoc />
    public virtual string GenusName => "Congopanchax";

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
