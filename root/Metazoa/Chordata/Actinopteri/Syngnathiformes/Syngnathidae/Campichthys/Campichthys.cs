using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Campichthys;

/// <summary>
/// Abstract class for Campichthys (genus).
/// NCBI TaxId: 2842158
/// </summary>
public abstract class Campichthys : Syngnathidae, ICampichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2842158;

    /// <inheritdoc />
    public virtual string GenusName => "Campichthys";

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
