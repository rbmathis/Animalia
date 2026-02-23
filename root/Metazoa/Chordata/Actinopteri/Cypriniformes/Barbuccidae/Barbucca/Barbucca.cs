using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Barbuccidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Barbuccidae.Barbucca;

/// <summary>
/// Abstract class for Barbucca (genus).
/// NCBI TaxId: 425499
/// </summary>
public abstract class Barbucca : Barbuccidae, IBarbucca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbucca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425499;

    /// <inheritdoc />
    public virtual string GenusName => "Barbucca";

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
