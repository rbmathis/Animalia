using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Aburria;

/// <summary>
/// Abstract class for Aburria (genus).
/// NCBI TaxId: 8988
/// </summary>
public abstract class Aburria : Cracidae, IAburria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aburria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8988;

    /// <inheritdoc />
    public virtual string GenusName => "Aburria";

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
