using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Thamnophilus;

/// <summary>
/// Abstract class for Thamnophilus (genus).
/// NCBI TaxId: 81888
/// </summary>
public abstract class Thamnophilus : Thamnophilidae, IThamnophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81888;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnophilus";

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
