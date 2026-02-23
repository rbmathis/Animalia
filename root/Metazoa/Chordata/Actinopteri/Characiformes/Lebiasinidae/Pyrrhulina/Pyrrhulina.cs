using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Pyrrhulina;

/// <summary>
/// Abstract class for Pyrrhulina (genus).
/// NCBI TaxId: 42608
/// </summary>
public abstract class Pyrrhulina : Lebiasinidae, IPyrrhulina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhulina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42608;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhulina";

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
