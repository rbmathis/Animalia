using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Synaptolaemus;

/// <summary>
/// Abstract class for Synaptolaemus (genus).
/// NCBI TaxId: 2608195
/// </summary>
public abstract class Synaptolaemus : Anostomidae, ISynaptolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synaptolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608195;

    /// <inheritdoc />
    public virtual string GenusName => "Synaptolaemus";

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
