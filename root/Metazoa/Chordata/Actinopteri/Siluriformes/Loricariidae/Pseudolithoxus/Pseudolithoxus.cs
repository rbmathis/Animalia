using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudolithoxus;

/// <summary>
/// Abstract class for Pseudolithoxus (genus).
/// NCBI TaxId: 281764
/// </summary>
public abstract class Pseudolithoxus : Loricariidae, IPseudolithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudolithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281764;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudolithoxus";

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
