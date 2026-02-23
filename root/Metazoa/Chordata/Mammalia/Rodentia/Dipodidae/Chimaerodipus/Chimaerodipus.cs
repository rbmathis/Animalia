using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Chimaerodipus;

/// <summary>
/// Abstract class for Chimaerodipus (genus).
/// NCBI TaxId: 2171714
/// </summary>
public abstract class Chimaerodipus : Dipodidae, IChimaerodipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chimaerodipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2171714;

    /// <inheritdoc />
    public virtual string GenusName => "Chimaerodipus";

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
