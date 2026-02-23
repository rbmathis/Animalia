using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Chela;

/// <summary>
/// Abstract class for Chela (genus).
/// NCBI TaxId: 432405
/// </summary>
public abstract class Chela : Danionidae, IChela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432405;

    /// <inheritdoc />
    public virtual string GenusName => "Chela";

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
