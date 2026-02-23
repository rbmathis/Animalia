using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Rasboroides;

/// <summary>
/// Abstract class for Rasboroides (genus).
/// NCBI TaxId: 2491141
/// </summary>
public abstract class Rasboroides : Danionidae, IRasboroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rasboroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2491141;

    /// <inheritdoc />
    public virtual string GenusName => "Rasboroides";

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
