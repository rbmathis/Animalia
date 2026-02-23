using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Scotocercidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Scotocercidae.Horornis;

/// <summary>
/// Abstract class for Horornis (genus).
/// NCBI TaxId: 1592217
/// </summary>
public abstract class Horornis : Scotocercidae, IHorornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Horornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1592217;

    /// <inheritdoc />
    public virtual string GenusName => "Horornis";

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
