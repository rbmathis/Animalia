using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Numida;

/// <summary>
/// Abstract class for Numida (genus).
/// NCBI TaxId: 8995
/// </summary>
public abstract class Numida : Numididae, INumida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Numida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8995;

    /// <inheritdoc />
    public virtual string GenusName => "Numida";

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
