using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Pithys;

/// <summary>
/// Abstract class for Pithys (genus).
/// NCBI TaxId: 265641
/// </summary>
public abstract class Pithys : Thamnophilidae, IPithys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pithys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265641;

    /// <inheritdoc />
    public virtual string GenusName => "Pithys";

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
