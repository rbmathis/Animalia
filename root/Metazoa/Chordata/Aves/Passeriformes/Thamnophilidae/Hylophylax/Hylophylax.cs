using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Hylophylax;

/// <summary>
/// Abstract class for Hylophylax (genus).
/// NCBI TaxId: 288091
/// </summary>
public abstract class Hylophylax : Thamnophilidae, IHylophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288091;

    /// <inheritdoc />
    public virtual string GenusName => "Hylophylax";

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
