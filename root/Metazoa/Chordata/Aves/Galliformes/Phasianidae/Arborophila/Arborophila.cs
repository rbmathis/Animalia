using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Arborophila;

/// <summary>
/// Abstract class for Arborophila (genus).
/// NCBI TaxId: 9104
/// </summary>
public abstract class Arborophila : Phasianidae, IArborophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arborophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9104;

    /// <inheritdoc />
    public virtual string GenusName => "Arborophila";

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
