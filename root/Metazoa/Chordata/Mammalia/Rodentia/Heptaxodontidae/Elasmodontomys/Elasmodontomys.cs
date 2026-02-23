using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heptaxodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heptaxodontidae.Elasmodontomys;

/// <summary>
/// Abstract class for Elasmodontomys (genus).
/// NCBI TaxId: 2779811
/// </summary>
public abstract class Elasmodontomys : Heptaxodontidae, IElasmodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elasmodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2779811;

    /// <inheritdoc />
    public virtual string GenusName => "Elasmodontomys";

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
