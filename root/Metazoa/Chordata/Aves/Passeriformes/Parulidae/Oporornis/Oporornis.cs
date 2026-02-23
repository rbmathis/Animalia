using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Oporornis;

/// <summary>
/// Abstract class for Oporornis (genus).
/// NCBI TaxId: 142473
/// </summary>
public abstract class Oporornis : Parulidae, IOporornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oporornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 142473;

    /// <inheritdoc />
    public virtual string GenusName => "Oporornis";

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
