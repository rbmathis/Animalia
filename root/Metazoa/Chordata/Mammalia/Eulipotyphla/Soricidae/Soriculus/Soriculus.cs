using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Soriculus;

/// <summary>
/// Abstract class for Soriculus (genus).
/// NCBI TaxId: 62290
/// </summary>
public abstract class Soriculus : Soricidae, ISoriculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Soriculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62290;

    /// <inheritdoc />
    public virtual string GenusName => "Soriculus";

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
