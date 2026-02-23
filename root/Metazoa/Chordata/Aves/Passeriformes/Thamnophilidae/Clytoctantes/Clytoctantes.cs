using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Clytoctantes;

/// <summary>
/// Abstract class for Clytoctantes (genus).
/// NCBI TaxId: 2724882
/// </summary>
public abstract class Clytoctantes : Thamnophilidae, IClytoctantes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clytoctantes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2724882;

    /// <inheritdoc />
    public virtual string GenusName => "Clytoctantes";

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
