using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Yarrella;

/// <summary>
/// Abstract class for Yarrella (genus).
/// NCBI TaxId: 700679
/// </summary>
public abstract class Yarrella : Phosichthyidae, IYarrella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yarrella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700679;

    /// <inheritdoc />
    public virtual string GenusName => "Yarrella";

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
