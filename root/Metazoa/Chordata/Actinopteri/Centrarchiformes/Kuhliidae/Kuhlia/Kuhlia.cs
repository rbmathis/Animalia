using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae.Kuhlia;

/// <summary>
/// Abstract class for Kuhlia (genus).
/// NCBI TaxId: 163136
/// </summary>
public abstract class Kuhlia : Kuhliidae, IKuhlia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kuhlia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163136;

    /// <inheritdoc />
    public virtual string GenusName => "Kuhlia";

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
