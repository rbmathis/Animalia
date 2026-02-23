using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Liachirus;

/// <summary>
/// Abstract class for Liachirus (genus).
/// NCBI TaxId: 1286139
/// </summary>
public abstract class Liachirus : Soleidae, ILiachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1286139;

    /// <inheritdoc />
    public virtual string GenusName => "Liachirus";

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
