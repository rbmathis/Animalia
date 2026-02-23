using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Frederickena;

/// <summary>
/// Abstract class for Frederickena (genus).
/// NCBI TaxId: 265637
/// </summary>
public abstract class Frederickena : Thamnophilidae, IFrederickena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Frederickena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265637;

    /// <inheritdoc />
    public virtual string GenusName => "Frederickena";

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
