using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Bryconops;

/// <summary>
/// Abstract class for Bryconops (genus).
/// NCBI TaxId: 303988
/// </summary>
public abstract class Bryconops : Iguanodectidae, IBryconops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303988;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconops";

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
