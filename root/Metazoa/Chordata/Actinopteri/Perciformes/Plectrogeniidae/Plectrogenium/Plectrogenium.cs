using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Plectrogeniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Plectrogeniidae.Plectrogenium;

/// <summary>
/// Abstract class for Plectrogenium (genus).
/// NCBI TaxId: 274733
/// </summary>
public abstract class Plectrogenium : Plectrogeniidae, IPlectrogenium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectrogenium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274733;

    /// <inheritdoc />
    public virtual string GenusName => "Plectrogenium";

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
