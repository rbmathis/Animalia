using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Eremodipus;

/// <summary>
/// Abstract class for Eremodipus (genus).
/// NCBI TaxId: 35738
/// </summary>
public abstract class Eremodipus : Dipodidae, IEremodipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremodipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35738;

    /// <inheritdoc />
    public virtual string GenusName => "Eremodipus";

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
