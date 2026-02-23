using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Starksia;

/// <summary>
/// Abstract class for Starksia (genus).
/// NCBI TaxId: 57854
/// </summary>
public abstract class Starksia : Labrisomidae, IStarksia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Starksia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57854;

    /// <inheritdoc />
    public virtual string GenusName => "Starksia";

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
