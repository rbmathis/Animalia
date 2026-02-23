using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelochelys;

/// <summary>
/// Abstract class for Pelochelys (genus).
/// NCBI TaxId: 129892
/// </summary>
public abstract class Pelochelys : Trionychidae, IPelochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129892;

    /// <inheritdoc />
    public virtual string GenusName => "Pelochelys";

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
