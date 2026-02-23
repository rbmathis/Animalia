using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Batara;

/// <summary>
/// Abstract class for Batara (genus).
/// NCBI TaxId: 288053
/// </summary>
public abstract class Batara : Thamnophilidae, IBatara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288053;

    /// <inheritdoc />
    public virtual string GenusName => "Batara";

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
