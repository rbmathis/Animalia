using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Vanga;

/// <summary>
/// Abstract class for Vanga (genus).
/// NCBI TaxId: 125300
/// </summary>
public abstract class Vanga : Vangidae, IVanga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vanga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125300;

    /// <inheritdoc />
    public virtual string GenusName => "Vanga";

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
