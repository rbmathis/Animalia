using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Enoplosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Enoplosidae.Enoplosus;

/// <summary>
/// Abstract class for Enoplosus (genus).
/// NCBI TaxId: 215366
/// </summary>
public abstract class Enoplosus : Enoplosidae, IEnoplosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enoplosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215366;

    /// <inheritdoc />
    public virtual string GenusName => "Enoplosus";

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
