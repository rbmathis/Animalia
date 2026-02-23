using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Nerophis;

/// <summary>
/// Abstract class for Nerophis (genus).
/// NCBI TaxId: 159076
/// </summary>
public abstract class Nerophis : Syngnathidae, INerophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nerophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159076;

    /// <inheritdoc />
    public virtual string GenusName => "Nerophis";

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
