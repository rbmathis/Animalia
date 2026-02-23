using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophichthus;

/// <summary>
/// Abstract class for Ophichthus (genus).
/// NCBI TaxId: 54917
/// </summary>
public abstract class Ophichthus : Ophichthidae, IOphichthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophichthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54917;

    /// <inheritdoc />
    public virtual string GenusName => "Ophichthus";

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
