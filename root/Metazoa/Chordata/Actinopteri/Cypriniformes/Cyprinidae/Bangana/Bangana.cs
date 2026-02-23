using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Bangana;

/// <summary>
/// Abstract class for Bangana (genus).
/// NCBI TaxId: 643445
/// </summary>
public abstract class Bangana : Cyprinidae, IBangana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bangana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643445;

    /// <inheritdoc />
    public virtual string GenusName => "Bangana";

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
