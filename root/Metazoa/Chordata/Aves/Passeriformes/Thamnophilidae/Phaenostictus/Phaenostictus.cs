using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Phaenostictus;

/// <summary>
/// Abstract class for Phaenostictus (genus).
/// NCBI TaxId: 288077
/// </summary>
public abstract class Phaenostictus : Thamnophilidae, IPhaenostictus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaenostictus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288077;

    /// <inheritdoc />
    public virtual string GenusName => "Phaenostictus";

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
