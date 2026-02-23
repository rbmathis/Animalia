using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Corythoichthys;

/// <summary>
/// Abstract class for Corythoichthys (genus).
/// NCBI TaxId: 161447
/// </summary>
public abstract class Corythoichthys : Syngnathidae, ICorythoichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corythoichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161447;

    /// <inheritdoc />
    public virtual string GenusName => "Corythoichthys";

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
