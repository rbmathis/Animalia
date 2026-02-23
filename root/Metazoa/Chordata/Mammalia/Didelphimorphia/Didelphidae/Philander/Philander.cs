using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Philander;

/// <summary>
/// Abstract class for Philander (genus).
/// NCBI TaxId: 9271
/// </summary>
public abstract class Philander : Didelphidae, IPhilander
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philander";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9271;

    /// <inheritdoc />
    public virtual string GenusName => "Philander";

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
