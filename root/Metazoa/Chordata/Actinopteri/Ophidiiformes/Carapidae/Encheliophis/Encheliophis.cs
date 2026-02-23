using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Encheliophis;

/// <summary>
/// Abstract class for Encheliophis (genus).
/// NCBI TaxId: 1819255
/// </summary>
public abstract class Encheliophis : Carapidae, IEncheliophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Encheliophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1819255;

    /// <inheritdoc />
    public virtual string GenusName => "Encheliophis";

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
