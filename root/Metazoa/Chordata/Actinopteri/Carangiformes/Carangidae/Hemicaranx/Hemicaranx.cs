using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Hemicaranx;

/// <summary>
/// Abstract class for Hemicaranx (genus).
/// NCBI TaxId: 173307
/// </summary>
public abstract class Hemicaranx : Carangidae, IHemicaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemicaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173307;

    /// <inheritdoc />
    public virtual string GenusName => "Hemicaranx";

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
