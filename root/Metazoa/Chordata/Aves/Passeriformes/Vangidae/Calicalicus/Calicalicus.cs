using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Calicalicus;

/// <summary>
/// Abstract class for Calicalicus (genus).
/// NCBI TaxId: 1132578
/// </summary>
public abstract class Calicalicus : Vangidae, ICalicalicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calicalicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1132578;

    /// <inheritdoc />
    public virtual string GenusName => "Calicalicus";

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
