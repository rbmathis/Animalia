using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Notamacropus;

/// <summary>
/// Abstract class for Notamacropus (genus).
/// NCBI TaxId: 1960649
/// </summary>
public abstract class Notamacropus : Macropodidae, INotamacropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notamacropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1960649;

    /// <inheritdoc />
    public virtual string GenusName => "Notamacropus";

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
