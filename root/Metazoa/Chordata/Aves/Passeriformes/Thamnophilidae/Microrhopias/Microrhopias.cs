using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Microrhopias;

/// <summary>
/// Abstract class for Microrhopias (genus).
/// NCBI TaxId: 288083
/// </summary>
public abstract class Microrhopias : Thamnophilidae, IMicrorhopias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microrhopias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288083;

    /// <inheritdoc />
    public virtual string GenusName => "Microrhopias";

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
