using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Neoctantes;

/// <summary>
/// Abstract class for Neoctantes (genus).
/// NCBI TaxId: 288087
/// </summary>
public abstract class Neoctantes : Thamnophilidae, INeoctantes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoctantes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288087;

    /// <inheritdoc />
    public virtual string GenusName => "Neoctantes";

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
