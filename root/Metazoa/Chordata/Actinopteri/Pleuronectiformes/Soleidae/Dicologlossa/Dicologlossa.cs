using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Dicologlossa;

/// <summary>
/// Abstract class for Dicologlossa (genus).
/// NCBI TaxId: 153208
/// </summary>
public abstract class Dicologlossa : Soleidae, IDicologlossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicologlossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153208;

    /// <inheritdoc />
    public virtual string GenusName => "Dicologlossa";

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
