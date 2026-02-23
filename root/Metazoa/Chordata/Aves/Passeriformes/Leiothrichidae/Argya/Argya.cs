using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Argya;

/// <summary>
/// Abstract class for Argya (genus).
/// NCBI TaxId: 2183803
/// </summary>
public abstract class Argya : Leiothrichidae, IArgya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2183803;

    /// <inheritdoc />
    public virtual string GenusName => "Argya";

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
