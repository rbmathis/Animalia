using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Gnathodolus;

/// <summary>
/// Abstract class for Gnathodolus (genus).
/// NCBI TaxId: 2499842
/// </summary>
public abstract class Gnathodolus : Anostomidae, IGnathodolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathodolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499842;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathodolus";

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
