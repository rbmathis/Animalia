using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Herpsilochmus;

/// <summary>
/// Abstract class for Herpsilochmus (genus).
/// NCBI TaxId: 88172
/// </summary>
public abstract class Herpsilochmus : Thamnophilidae, IHerpsilochmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herpsilochmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88172;

    /// <inheritdoc />
    public virtual string GenusName => "Herpsilochmus";

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
