using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Lanius;

/// <summary>
/// Abstract class for Lanius (genus).
/// NCBI TaxId: 28712
/// </summary>
public abstract class Lanius : Laniidae, ILanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28712;

    /// <inheritdoc />
    public virtual string GenusName => "Lanius";

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
