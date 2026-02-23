using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Drepaneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Drepaneidae.Drepane;

/// <summary>
/// Abstract class for Drepane (genus).
/// NCBI TaxId: 75021
/// </summary>
public abstract class Drepane : Drepaneidae, IDrepane
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drepane";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75021;

    /// <inheritdoc />
    public virtual string GenusName => "Drepane";

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
