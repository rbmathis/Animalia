using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lithoxus;

/// <summary>
/// Abstract class for Lithoxus (genus).
/// NCBI TaxId: 1137729
/// </summary>
public abstract class Lithoxus : Loricariidae, ILithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1137729;

    /// <inheritdoc />
    public virtual string GenusName => "Lithoxus";

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
