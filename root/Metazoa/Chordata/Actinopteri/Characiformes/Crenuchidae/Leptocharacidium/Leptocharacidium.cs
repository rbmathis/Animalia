using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Leptocharacidium;

/// <summary>
/// Abstract class for Leptocharacidium (genus).
/// NCBI TaxId: 2608199
/// </summary>
public abstract class Leptocharacidium : Crenuchidae, ILeptocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608199;

    /// <inheritdoc />
    public virtual string GenusName => "Leptocharacidium";

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
