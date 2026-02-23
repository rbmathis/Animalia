using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Taraba;

/// <summary>
/// Abstract class for Taraba (genus).
/// NCBI TaxId: 288055
/// </summary>
public abstract class Taraba : Thamnophilidae, ITaraba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taraba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288055;

    /// <inheritdoc />
    public virtual string GenusName => "Taraba";

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
