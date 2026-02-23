using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Malacoctenus;

/// <summary>
/// Abstract class for Malacoctenus (genus).
/// NCBI TaxId: 57773
/// </summary>
public abstract class Malacoctenus : Labrisomidae, IMalacoctenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacoctenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57773;

    /// <inheritdoc />
    public virtual string GenusName => "Malacoctenus";

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
