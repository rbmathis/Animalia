using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Pteropsaron;

/// <summary>
/// Abstract class for Pteropsaron (genus).
/// NCBI TaxId: 1672028
/// </summary>
public abstract class Pteropsaron : Percophidae, IPteropsaron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteropsaron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1672028;

    /// <inheritdoc />
    public virtual string GenusName => "Pteropsaron";

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
