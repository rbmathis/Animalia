using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Carangoides;

/// <summary>
/// Abstract class for Carangoides (genus).
/// NCBI TaxId: 179360
/// </summary>
public abstract class Carangoides : Carangidae, ICarangoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carangoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 179360;

    /// <inheritdoc />
    public virtual string GenusName => "Carangoides";

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
