using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Oligosarcus;

/// <summary>
/// Abstract class for Oligosarcus (genus).
/// NCBI TaxId: 42578
/// </summary>
public abstract class Oligosarcus : Acestrorhamphidae, IOligosarcus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligosarcus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42578;

    /// <inheritdoc />
    public virtual string GenusName => "Oligosarcus";

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
