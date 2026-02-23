using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Sclateria;

/// <summary>
/// Abstract class for Sclateria (genus).
/// NCBI TaxId: 288097
/// </summary>
public abstract class Sclateria : Thamnophilidae, ISclateria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sclateria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288097;

    /// <inheritdoc />
    public virtual string GenusName => "Sclateria";

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
