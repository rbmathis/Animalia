using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireolanius;

/// <summary>
/// Abstract class for Vireolanius (genus).
/// NCBI TaxId: 34959
/// </summary>
public abstract class Vireolanius : Vireonidae, IVireolanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vireolanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34959;

    /// <inheritdoc />
    public virtual string GenusName => "Vireolanius";

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
