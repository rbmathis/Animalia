using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Plectropomus;

/// <summary>
/// Abstract class for Plectropomus (genus).
/// NCBI TaxId: 134629
/// </summary>
public abstract class Plectropomus : Serranidae, IPlectropomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectropomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 134629;

    /// <inheritdoc />
    public virtual string GenusName => "Plectropomus";

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
