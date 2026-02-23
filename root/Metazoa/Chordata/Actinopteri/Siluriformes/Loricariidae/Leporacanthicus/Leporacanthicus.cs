using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Leporacanthicus;

/// <summary>
/// Abstract class for Leporacanthicus (genus).
/// NCBI TaxId: 281761
/// </summary>
public abstract class Leporacanthicus : Loricariidae, ILeporacanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leporacanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281761;

    /// <inheritdoc />
    public virtual string GenusName => "Leporacanthicus";

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
