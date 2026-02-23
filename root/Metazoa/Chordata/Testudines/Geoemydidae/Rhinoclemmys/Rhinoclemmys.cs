using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Rhinoclemmys;

/// <summary>
/// Abstract class for Rhinoclemmys (genus).
/// NCBI TaxId: 260640
/// </summary>
public abstract class Rhinoclemmys : Geoemydidae, IRhinoclemmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoclemmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260640;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoclemmys";

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
