using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tigrigobius;

/// <summary>
/// Abstract class for Tigrigobius (genus).
/// NCBI TaxId: 203331
/// </summary>
public abstract class Tigrigobius : Gobiidae, ITigrigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tigrigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203331;

    /// <inheritdoc />
    public virtual string GenusName => "Tigrigobius";

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
