using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Abstract class for Mauremys (genus).
/// NCBI TaxId: 74925
/// </summary>
public abstract class Mauremys : Geoemydidae, IMauremys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mauremys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74925;

    /// <inheritdoc />
    public virtual string GenusName => "Mauremys";

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
