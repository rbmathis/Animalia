using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lankascincus;

/// <summary>
/// Abstract class for Lankascincus (genus).
/// NCBI TaxId: 245626
/// </summary>
public abstract class Lankascincus : Scincidae, ILankascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lankascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245626;

    /// <inheritdoc />
    public virtual string GenusName => "Lankascincus";

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
