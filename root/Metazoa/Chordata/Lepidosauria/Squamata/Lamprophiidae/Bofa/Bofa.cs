using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Bofa;

/// <summary>
/// Abstract class for Bofa (genus).
/// NCBI TaxId: 3148927
/// </summary>
public abstract class Bofa : Lamprophiidae, IBofa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bofa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148927;

    /// <inheritdoc />
    public virtual string GenusName => "Bofa";

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
