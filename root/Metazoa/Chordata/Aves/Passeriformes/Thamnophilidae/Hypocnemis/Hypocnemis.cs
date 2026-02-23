using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Hypocnemis;

/// <summary>
/// Abstract class for Hypocnemis (genus).
/// NCBI TaxId: 88174
/// </summary>
public abstract class Hypocnemis : Thamnophilidae, IHypocnemis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypocnemis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88174;

    /// <inheritdoc />
    public virtual string GenusName => "Hypocnemis";

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
