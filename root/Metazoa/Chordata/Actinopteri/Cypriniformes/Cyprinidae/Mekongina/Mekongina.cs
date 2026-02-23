using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mekongina;

/// <summary>
/// Abstract class for Mekongina (genus).
/// NCBI TaxId: 685032
/// </summary>
public abstract class Mekongina : Cyprinidae, IMekongina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mekongina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685032;

    /// <inheritdoc />
    public virtual string GenusName => "Mekongina";

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
