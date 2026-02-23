using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Cyclothone;

/// <summary>
/// Abstract class for Cyclothone (genus).
/// NCBI TaxId: 48440
/// </summary>
public abstract class Cyclothone : Gonostomatidae, ICyclothone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclothone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48440;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclothone";

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
