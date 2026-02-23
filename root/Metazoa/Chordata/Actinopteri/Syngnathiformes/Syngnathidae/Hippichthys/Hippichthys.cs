using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Hippichthys;

/// <summary>
/// Abstract class for Hippichthys (genus).
/// NCBI TaxId: 161459
/// </summary>
public abstract class Hippichthys : Syngnathidae, IHippichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161459;

    /// <inheritdoc />
    public virtual string GenusName => "Hippichthys";

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
