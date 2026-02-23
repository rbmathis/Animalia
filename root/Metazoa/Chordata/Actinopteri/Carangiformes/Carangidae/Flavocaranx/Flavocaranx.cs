using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Flavocaranx;

/// <summary>
/// Abstract class for Flavocaranx (genus).
/// NCBI TaxId: 3040447
/// </summary>
public abstract class Flavocaranx : Carangidae, IFlavocaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Flavocaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040447;

    /// <inheritdoc />
    public virtual string GenusName => "Flavocaranx";

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
