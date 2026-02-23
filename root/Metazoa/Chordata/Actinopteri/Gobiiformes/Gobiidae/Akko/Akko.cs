using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Akko;

/// <summary>
/// Abstract class for Akko (genus).
/// NCBI TaxId: 203341
/// </summary>
public abstract class Akko : Gobiidae, IAkko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Akko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203341;

    /// <inheritdoc />
    public virtual string GenusName => "Akko";

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
