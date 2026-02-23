using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ninnigobius;

/// <summary>
/// Abstract class for Ninnigobius (genus).
/// NCBI TaxId: 1484169
/// </summary>
public abstract class Ninnigobius : Gobiidae, INinnigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ninnigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1484169;

    /// <inheritdoc />
    public virtual string GenusName => "Ninnigobius";

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
