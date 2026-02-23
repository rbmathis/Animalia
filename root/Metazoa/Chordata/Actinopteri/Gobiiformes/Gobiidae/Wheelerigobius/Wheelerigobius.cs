using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Wheelerigobius;

/// <summary>
/// Abstract class for Wheelerigobius (genus).
/// NCBI TaxId: 1365721
/// </summary>
public abstract class Wheelerigobius : Gobiidae, IWheelerigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wheelerigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365721;

    /// <inheritdoc />
    public virtual string GenusName => "Wheelerigobius";

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
