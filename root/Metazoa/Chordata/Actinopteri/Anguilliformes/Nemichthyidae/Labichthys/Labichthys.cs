using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae.Labichthys;

/// <summary>
/// Abstract class for Labichthys (genus).
/// NCBI TaxId: 556241
/// </summary>
public abstract class Labichthys : Nemichthyidae, ILabichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556241;

    /// <inheritdoc />
    public virtual string GenusName => "Labichthys";

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
