using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Paralithoxus;

/// <summary>
/// Abstract class for Paralithoxus (genus).
/// NCBI TaxId: 2482809
/// </summary>
public abstract class Paralithoxus : Loricariidae, IParalithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2482809;

    /// <inheritdoc />
    public virtual string GenusName => "Paralithoxus";

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
