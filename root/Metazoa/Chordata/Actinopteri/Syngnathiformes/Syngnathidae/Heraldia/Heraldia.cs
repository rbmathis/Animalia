using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Heraldia;

/// <summary>
/// Abstract class for Heraldia (genus).
/// NCBI TaxId: 1914719
/// </summary>
public abstract class Heraldia : Syngnathidae, IHeraldia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heraldia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914719;

    /// <inheritdoc />
    public virtual string GenusName => "Heraldia";

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
