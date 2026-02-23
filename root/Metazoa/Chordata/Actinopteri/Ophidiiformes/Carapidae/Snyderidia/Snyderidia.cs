using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Snyderidia;

/// <summary>
/// Abstract class for Snyderidia (genus).
/// NCBI TaxId: 3111724
/// </summary>
public abstract class Snyderidia : Carapidae, ISnyderidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Snyderidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3111724;

    /// <inheritdoc />
    public virtual string GenusName => "Snyderidia";

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
