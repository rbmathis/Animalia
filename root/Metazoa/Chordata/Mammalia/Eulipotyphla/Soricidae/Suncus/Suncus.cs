using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Abstract class for Suncus (genus).
/// NCBI TaxId: 9377
/// </summary>
public abstract class Suncus : Soricidae, ISuncus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suncus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9377;

    /// <inheritdoc />
    public virtual string GenusName => "Suncus";

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
