using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Gadopsis;

/// <summary>
/// Abstract class for Gadopsis (genus).
/// NCBI TaxId: 135753
/// </summary>
public abstract class Gadopsis : Percichthyidae, IGadopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gadopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135753;

    /// <inheritdoc />
    public virtual string GenusName => "Gadopsis";

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
