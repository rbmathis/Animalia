using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Sipia;

/// <summary>
/// Abstract class for Sipia (genus).
/// NCBI TaxId: 2765391
/// </summary>
public abstract class Sipia : Thamnophilidae, ISipia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sipia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2765391;

    /// <inheritdoc />
    public virtual string GenusName => "Sipia";

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
