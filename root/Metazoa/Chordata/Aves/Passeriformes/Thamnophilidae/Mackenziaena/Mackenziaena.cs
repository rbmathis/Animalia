using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Mackenziaena;

/// <summary>
/// Abstract class for Mackenziaena (genus).
/// NCBI TaxId: 288049
/// </summary>
public abstract class Mackenziaena : Thamnophilidae, IMackenziaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mackenziaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288049;

    /// <inheritdoc />
    public virtual string GenusName => "Mackenziaena";

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
