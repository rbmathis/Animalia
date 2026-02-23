using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Terenura;

/// <summary>
/// Abstract class for Terenura (genus).
/// NCBI TaxId: 88182
/// </summary>
public abstract class Terenura : Thamnophilidae, ITerenura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terenura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88182;

    /// <inheritdoc />
    public virtual string GenusName => "Terenura";

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
