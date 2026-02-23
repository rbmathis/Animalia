using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Metaloricaria;

/// <summary>
/// Abstract class for Metaloricaria (genus).
/// NCBI TaxId: 503158
/// </summary>
public abstract class Metaloricaria : Loricariidae, IMetaloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metaloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503158;

    /// <inheritdoc />
    public virtual string GenusName => "Metaloricaria";

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
