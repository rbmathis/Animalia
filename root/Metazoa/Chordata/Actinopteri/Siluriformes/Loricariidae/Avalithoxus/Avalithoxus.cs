using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Avalithoxus;

/// <summary>
/// Abstract class for Avalithoxus (genus).
/// NCBI TaxId: 2529310
/// </summary>
public abstract class Avalithoxus : Loricariidae, IAvalithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Avalithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2529310;

    /// <inheritdoc />
    public virtual string GenusName => "Avalithoxus";

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
