using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Geoxus;

/// <summary>
/// Abstract class for Geoxus (genus).
/// NCBI TaxId: 29110
/// </summary>
public abstract class Geoxus : Cricetidae, IGeoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29110;

    /// <inheritdoc />
    public virtual string GenusName => "Geoxus";

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
