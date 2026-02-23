using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Sciaphylax;

/// <summary>
/// Abstract class for Sciaphylax (genus).
/// NCBI TaxId: 2767941
/// </summary>
public abstract class Sciaphylax : Thamnophilidae, ISciaphylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciaphylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767941;

    /// <inheritdoc />
    public virtual string GenusName => "Sciaphylax";

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
