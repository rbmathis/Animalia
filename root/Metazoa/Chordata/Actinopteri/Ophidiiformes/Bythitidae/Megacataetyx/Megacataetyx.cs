using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Megacataetyx;

/// <summary>
/// Abstract class for Megacataetyx (genus).
/// NCBI TaxId: 2893510
/// </summary>
public abstract class Megacataetyx : Bythitidae, IMegacataetyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megacataetyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893510;

    /// <inheritdoc />
    public virtual string GenusName => "Megacataetyx";

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
