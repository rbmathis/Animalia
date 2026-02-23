using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lesueurigobius;

/// <summary>
/// Abstract class for Lesueurigobius (genus).
/// NCBI TaxId: 441904
/// </summary>
public abstract class Lesueurigobius : Gobiidae, ILesueurigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lesueurigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 441904;

    /// <inheritdoc />
    public virtual string GenusName => "Lesueurigobius";

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
