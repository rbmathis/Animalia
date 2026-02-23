using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ahlia;

/// <summary>
/// Abstract class for Ahlia (genus).
/// NCBI TaxId: 182416
/// </summary>
public abstract class Ahlia : Ophichthidae, IAhlia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ahlia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182416;

    /// <inheritdoc />
    public virtual string GenusName => "Ahlia";

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
