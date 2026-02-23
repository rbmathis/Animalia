using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Parona;

/// <summary>
/// Abstract class for Parona (genus).
/// NCBI TaxId: 458595
/// </summary>
public abstract class Parona : Carangidae, IParona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458595;

    /// <inheritdoc />
    public virtual string GenusName => "Parona";

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
