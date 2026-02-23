using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

/// <summary>
/// Abstract class for Cyclemys (genus).
/// NCBI TaxId: 74915
/// </summary>
public abstract class Cyclemys : Geoemydidae, ICyclemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74915;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclemys";

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
