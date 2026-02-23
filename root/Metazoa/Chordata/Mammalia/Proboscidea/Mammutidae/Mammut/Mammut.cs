using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Mammutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Mammutidae.Mammut;

/// <summary>
/// Abstract class for Mammut (genus).
/// NCBI TaxId: 39051
/// </summary>
public abstract class Mammut : Mammutidae, IMammut
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mammut";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39051;

    /// <inheritdoc />
    public virtual string GenusName => "Mammut";

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
