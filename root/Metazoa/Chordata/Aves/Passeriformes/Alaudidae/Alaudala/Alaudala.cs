using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Alaudala;

/// <summary>
/// Abstract class for Alaudala (genus).
/// NCBI TaxId: 1862150
/// </summary>
public abstract class Alaudala : Alaudidae, IAlaudala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alaudala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1862150;

    /// <inheritdoc />
    public virtual string GenusName => "Alaudala";

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
