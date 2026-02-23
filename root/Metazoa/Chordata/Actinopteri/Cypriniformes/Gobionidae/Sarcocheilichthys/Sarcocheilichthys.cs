using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Sarcocheilichthys;

/// <summary>
/// Abstract class for Sarcocheilichthys (genus).
/// NCBI TaxId: 149979
/// </summary>
public abstract class Sarcocheilichthys : Gobionidae, ISarcocheilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcocheilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 149979;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcocheilichthys";

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
