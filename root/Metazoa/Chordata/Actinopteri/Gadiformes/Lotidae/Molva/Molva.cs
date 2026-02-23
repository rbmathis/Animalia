using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.Molva;

/// <summary>
/// Abstract class for Molva (genus).
/// NCBI TaxId: 163111
/// </summary>
public abstract class Molva : Lotidae, IMolva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Molva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163111;

    /// <inheritdoc />
    public virtual string GenusName => "Molva";

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
