using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Leptoichthys;

/// <summary>
/// Abstract class for Leptoichthys (genus).
/// NCBI TaxId: 1914724
/// </summary>
public abstract class Leptoichthys : Syngnathidae, ILeptoichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914724;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoichthys";

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
