using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Mitotichthys;

/// <summary>
/// Abstract class for Mitotichthys (genus).
/// NCBI TaxId: 1914732
/// </summary>
public abstract class Mitotichthys : Syngnathidae, IMitotichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mitotichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914732;

    /// <inheritdoc />
    public virtual string GenusName => "Mitotichthys";

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
