using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Rhinoleptus;

/// <summary>
/// Abstract class for Rhinoleptus (genus).
/// NCBI TaxId: 711333
/// </summary>
public abstract class Rhinoleptus : Leptotyphlopidae, IRhinoleptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoleptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711333;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoleptus";

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
