using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Parataeniophorus;

/// <summary>
/// Abstract class for Parataeniophorus (genus).
/// NCBI TaxId: 565082
/// </summary>
public abstract class Parataeniophorus : Cetomimidae, IParataeniophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parataeniophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 565082;

    /// <inheritdoc />
    public virtual string GenusName => "Parataeniophorus";

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
