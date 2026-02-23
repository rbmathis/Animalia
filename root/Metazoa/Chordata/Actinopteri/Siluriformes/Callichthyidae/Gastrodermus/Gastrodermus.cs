using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Gastrodermus;

/// <summary>
/// Abstract class for Gastrodermus (genus).
/// NCBI TaxId: 3162713
/// </summary>
public abstract class Gastrodermus : Callichthyidae, IGastrodermus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastrodermus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3162713;

    /// <inheritdoc />
    public virtual string GenusName => "Gastrodermus";

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
