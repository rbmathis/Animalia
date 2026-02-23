using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Serinus;

/// <summary>
/// Abstract class for Serinus (genus).
/// NCBI TaxId: 9134
/// </summary>
public abstract class Serinus : Fringillidae, ISerinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9134;

    /// <inheritdoc />
    public virtual string GenusName => "Serinus";

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
