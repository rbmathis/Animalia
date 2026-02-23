using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Xenotriccus;

/// <summary>
/// Abstract class for Xenotriccus (genus).
/// NCBI TaxId: 2338534
/// </summary>
public abstract class Xenotriccus : Tyrannidae, IXenotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2338534;

    /// <inheritdoc />
    public virtual string GenusName => "Xenotriccus";

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
