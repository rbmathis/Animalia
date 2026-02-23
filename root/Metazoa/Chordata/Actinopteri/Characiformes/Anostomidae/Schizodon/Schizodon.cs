using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Schizodon;

/// <summary>
/// Abstract class for Schizodon (genus).
/// NCBI TaxId: 490543
/// </summary>
public abstract class Schizodon : Anostomidae, ISchizodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490543;

    /// <inheritdoc />
    public virtual string GenusName => "Schizodon";

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
