using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Formicivora;

/// <summary>
/// Abstract class for Formicivora (genus).
/// NCBI TaxId: 88170
/// </summary>
public abstract class Formicivora : Thamnophilidae, IFormicivora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Formicivora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88170;

    /// <inheritdoc />
    public virtual string GenusName => "Formicivora";

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
