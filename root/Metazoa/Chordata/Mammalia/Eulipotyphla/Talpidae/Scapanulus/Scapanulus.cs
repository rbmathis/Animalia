using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Scapanulus;

/// <summary>
/// Abstract class for Scapanulus (genus).
/// NCBI TaxId: 1300116
/// </summary>
public abstract class Scapanulus : Talpidae, IScapanulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scapanulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1300116;

    /// <inheritdoc />
    public virtual string GenusName => "Scapanulus";

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
