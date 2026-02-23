using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Nematistiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Nematistiidae.Nematistius;

/// <summary>
/// Abstract class for Nematistius (genus).
/// NCBI TaxId: 173243
/// </summary>
public abstract class Nematistius : Nematistiidae, INematistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173243;

    /// <inheritdoc />
    public virtual string GenusName => "Nematistius";

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
