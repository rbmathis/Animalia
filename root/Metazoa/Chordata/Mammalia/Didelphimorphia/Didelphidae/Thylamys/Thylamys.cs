using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Thylamys;

/// <summary>
/// Abstract class for Thylamys (genus).
/// NCBI TaxId: 91501
/// </summary>
public abstract class Thylamys : Didelphidae, IThylamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thylamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91501;

    /// <inheritdoc />
    public virtual string GenusName => "Thylamys";

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
