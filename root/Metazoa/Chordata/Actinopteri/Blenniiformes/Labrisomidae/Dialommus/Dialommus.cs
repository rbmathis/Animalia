using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Dialommus;

/// <summary>
/// Abstract class for Dialommus (genus).
/// NCBI TaxId: 879816
/// </summary>
public abstract class Dialommus : Labrisomidae, IDialommus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dialommus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879816;

    /// <inheritdoc />
    public virtual string GenusName => "Dialommus";

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
