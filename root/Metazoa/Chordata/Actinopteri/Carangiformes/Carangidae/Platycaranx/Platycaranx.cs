using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Platycaranx;

/// <summary>
/// Abstract class for Platycaranx (genus).
/// NCBI TaxId: 3049893
/// </summary>
public abstract class Platycaranx : Carangidae, IPlatycaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platycaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049893;

    /// <inheritdoc />
    public virtual string GenusName => "Platycaranx";

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
