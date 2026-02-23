using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Neochela;

/// <summary>
/// Abstract class for Neochela (genus).
/// NCBI TaxId: 1906142
/// </summary>
public abstract class Neochela : Danionidae, INeochela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neochela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1906142;

    /// <inheritdoc />
    public virtual string GenusName => "Neochela";

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
