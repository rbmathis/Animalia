using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Typhlachirus;

/// <summary>
/// Abstract class for Typhlachirus (genus).
/// NCBI TaxId: 2813869
/// </summary>
public abstract class Typhlachirus : Soleidae, ITyphlachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2813869;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlachirus";

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
