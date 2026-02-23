using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Ketupa;

/// <summary>
/// Abstract class for Ketupa (genus).
/// NCBI TaxId: 126811
/// </summary>
public abstract class Ketupa : Strigidae, IKetupa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ketupa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126811;

    /// <inheritdoc />
    public virtual string GenusName => "Ketupa";

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
