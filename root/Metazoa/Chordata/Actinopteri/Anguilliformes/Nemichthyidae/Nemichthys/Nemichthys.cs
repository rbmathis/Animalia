using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae.Nemichthys;

/// <summary>
/// Abstract class for Nemichthys (genus).
/// NCBI TaxId: 118169
/// </summary>
public abstract class Nemichthys : Nemichthyidae, INemichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118169;

    /// <inheritdoc />
    public virtual string GenusName => "Nemichthys";

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
