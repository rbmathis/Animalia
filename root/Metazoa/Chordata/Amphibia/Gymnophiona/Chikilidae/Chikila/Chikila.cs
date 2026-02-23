using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Chikilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Chikilidae.Chikila;

/// <summary>
/// Abstract class for Chikila (genus).
/// NCBI TaxId: 1585921
/// </summary>
public abstract class Chikila : Chikilidae, IChikila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chikila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1585921;

    /// <inheritdoc />
    public virtual string GenusName => "Chikila";

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
