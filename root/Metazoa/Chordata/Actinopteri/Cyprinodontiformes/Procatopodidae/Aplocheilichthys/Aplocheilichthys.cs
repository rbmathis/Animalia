using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Aplocheilichthys;

/// <summary>
/// Abstract class for Aplocheilichthys (genus).
/// NCBI TaxId: 28746
/// </summary>
public abstract class Aplocheilichthys : Procatopodidae, IAplocheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplocheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28746;

    /// <inheritdoc />
    public virtual string GenusName => "Aplocheilichthys";

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
